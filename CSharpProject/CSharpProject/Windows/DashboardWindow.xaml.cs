using CSharpProject.Data;
using CSharpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CSharpProject.Windows
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        private readonly LibrariyContext _context;
        private readonly Customer _customer;
        public DashboardWindow(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            _context = new LibrariyContext();
            FillBookData();


        }

        //Fill Book Data
        private void FillBookData()
        {
            DgvBook.ItemsSource = _context.Books.ToList();
        }

        private void BtnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            Book book = (Book)DgvBook.SelectedItem;

            if (book == default) return;

            if (DateTime.Now > DtpTime.SelectedDate)
            {
                MessageBox.Show("Köhnə tarix seçmək olmaz!");
                return;
            }

            DateTime expiredDate = (DateTime)DtpTime.SelectedDate;
            
            int dayCount = expiredDate.Day - DateTime.Now.Day;

            if (book.Quantity == 0)
            {
                MessageBox.Show("hal hazırda bu kitabdan kitabxanada yoxdur");
                return;
            }

            book.Quantity = book.Quantity - 1;

            Cart cart = new Cart
            {
                Name = book.Name,
                Price = book.Price * dayCount,
                WithdrawalDate = DateTime.Now,
                ExpirationDate = expiredDate,
                CustomerId = _customer.Id
            };

            _context.Carts.Add(cart);
            _context.SaveChanges();

            MessageBox.Show("Səbətə kitab əlavə edildi");
        }

        private void CartDashboard_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cartWindow = new CartWindow(_customer);
            cartWindow.ShowDialog();
        }
    }
}

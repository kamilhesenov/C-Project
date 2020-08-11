using CSharpProject.Data;
using CSharpProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows;


namespace CSharpProject.Windows
{
   
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
            FillTabs();

        }

        //Fill Book Data
        public void FillBookData()
        {
            DgvBook.ItemsSource = null;
            DgvBook.ItemsSource = _context.Books.ToList();
        }

        //Add to Cart
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
            FillBookData();
            MessageBox.Show("Səbətə kitab əlavə edildi");
        }

        //Open CartDashboard
        private void CartDashboard_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cartWindow = new CartWindow(_customer,this);
            cartWindow.ShowDialog();
        }

        //Tab Menu
        private void FillTabs()
        {
            DgvTodayReturn.ItemsSource = _context.Carts.Include(x => x.Customer)
            .Where(x=> x.ExpirationDate.Date == DateTime.Now.Date).Select(x=> new { 
            Id = x.Id,
            Name = x.Name,
            CustomeName = x.Customer.Name,
            Phone = x.Customer.Phone,
            Count = x.Customer.Carts.Count
            }).ToList();

            DgvTommorrowReturn.ItemsSource = _context.Carts.Include(x => x.Customer)
           .Where(x=> x.ExpirationDate.Date == DateTime.Now.Date.AddDays(1)).Select(x => new {
               Id = x.Id,
               Name = x.Name,
               CustomeName = x.Customer.Name,
               Phone = x.Customer.Phone,
               Count = x.Customer.Carts.Count
           }).ToList();

            DgvDeleyTime.ItemsSource = _context.Carts.Include(x => x.Customer)
              .Where(x=>x.ExpirationDate.Date < DateTime.Now.Date).Select(x => new {
                  Id = x.Id,
                  Name = x.Name,
                  CustomeName = x.Customer.Name,
                  Phone = x.Customer.Phone,
                  Count = x.Customer.Carts.Count
              }).ToList();
        }

      
    }
}

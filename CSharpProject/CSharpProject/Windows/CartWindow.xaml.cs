using CSharpProject.Data;
using CSharpProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;


namespace CSharpProject.Windows
{
    
    public partial class CartWindow : Window
    {
        private readonly LibrariyContext _context;
        private readonly Customer _customer;
        private readonly DashboardWindow _dashboardWindow;
        public CartWindow(Customer customer,DashboardWindow dashboardWindow)
        {
            InitializeComponent();
            _context = new LibrariyContext();
            _customer = customer;
            _dashboardWindow = dashboardWindow;
            FillCartData();
        }

        //Fill Cart Data
        private void FillCartData()
        {
            DgvCart.ItemsSource = _context.Carts.Where(x => x.IsOrder == false).Include(x => x.Customer).ToList();
               
        }

        //Delete Order
        private void BtnDelete_Order_Click(object sender, RoutedEventArgs e)
        {
            Cart cart = (Cart)DgvCart.SelectedItem;

            Book book = _context.Books.FirstOrDefault(x => x.Name == cart.Name);

            book.Quantity = book.Quantity + 1; 

            cart.IsOrder = true;

            _context.SaveChanges();
            FillCartData();
            _dashboardWindow.FillBookData();
            MessageBox.Show("Kitab qaytarıldı");
            
        }
    }
}

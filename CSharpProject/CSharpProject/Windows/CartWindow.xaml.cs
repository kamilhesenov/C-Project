using CSharpProject.Data;
using CSharpProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        //Search Customer
        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            List<Cart> carts = TxtSearch.Text == "" ?  _context.Carts.Where(x => x.IsOrder == false).Include(x => x.Customer).ToList() : 
            _context.Carts.Include(x=>x.Customer).Where(x => x.IsOrder == false && x.Customer.Name.ToLower().Contains(TxtSearch.Text.ToLower())).ToList();
            DgvCart.ItemsSource = carts;

        }

        //DelayTime
        private void BtnDelayTime_Click(object sender, RoutedEventArgs e)
        {
            Cart cart = (Cart)DgvCart.SelectedItem;

            if (cart == null) return;

            if (DtpDaleyTime.SelectedDate == null) return;


            DateTime date = (DateTime)DtpDaleyTime.SelectedDate;

            if (date < cart.ExpirationDate) return;

            cart.DelayTime = date;

            int day = date.Day - cart.ExpirationDate.Day;
            int dayCount = cart.ExpirationDate.Day - cart.WithdrawalDate.Day;
            decimal defaultPrice = cart.Price / dayCount;
            decimal delayPrice = defaultPrice * 0.005M * day;

            cart.Price += delayPrice;

            cart.IsOrder = true;
            _context.SaveChanges();

        }

       
    }
}

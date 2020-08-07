using CSharpProject.Data;
using CSharpProject.Models;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        private readonly LibrariyContext _context;
        private readonly Customer _customer;
        public CartWindow(Customer customer)
        {
            InitializeComponent();
            _context = new LibrariyContext();
            _customer = customer;
            FillCartData();
        }

        //Fill Cart Data
        private void FillCartData()
        {
            DgvCart.ItemsSource = _context.Carts.Include(x => x.Customer).ToList();
               
        }
    }
}

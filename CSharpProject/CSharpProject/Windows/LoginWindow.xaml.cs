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
    
    public partial class LoginWindow : Window
    {
        private readonly LibrariyContext _context;
        public LoginWindow()
        {
            InitializeComponent();
            _context = new LibrariyContext();
            Reset();
        }

        //TexBox Value Reset
        private void Reset()
        {
            TxtEmail.Clear();
            TxtPassword.Clear();
        }

        // TextBox Value Check
        private bool FormValidationCheck()
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                LblEmail.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblEmail.Foreground = new SolidColorBrush(Colors.Black);
            }

            if (string.IsNullOrEmpty(TxtPassword.Password))
            {
                LblPassword.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblPassword.Foreground = new SolidColorBrush(Colors.Black);
            }

            return hasError;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidationCheck())
            {
                MessageBox.Show("* olan yerləri boş buraxa bilməssiniz!");
                return;
            }

            Customer customer = _context.Customers.FirstOrDefault(x => x.Email == TxtEmail.Text);

            if (customer == null)
            {
                MessageBox.Show("Belə bir adda istifadəçi mövcud deyil!");
                return;
            }

            if (customer.Password != TxtPassword.Password)
            {
                MessageBox.Show("Email və ya Şifrə səhvdi");
                return;
            }

            DashboardWindow dashboardWindow = new DashboardWindow(customer);
            dashboardWindow.ShowDialog();
        }
    }
}

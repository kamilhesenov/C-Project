using CSharpProject.Data;
using CSharpProject.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace CSharpProject.Windows
{
    
    public partial class CustomerWindow : Window
    {
        private readonly LibrariyContext _context;
        private Customer _selectedCustomer;
        public CustomerWindow()
        {
            InitializeComponent();
            _context = new LibrariyContext();
            FillCustomerData();
        }
        //Textbox Value Check
        private bool FormValidationCheck()
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(TxtName.Text))
            {
                LblName.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblName.Foreground = new SolidColorBrush(Colors.Black);
            }

            if (string.IsNullOrEmpty(TxtSurname.Text))
            {
                LblSurname.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblSurname.Foreground = new SolidColorBrush(Colors.Black);
            }

            if (string.IsNullOrEmpty(TxtPhone.Text))
            {
                LblPhone.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblPhone.Foreground = new SolidColorBrush(Colors.Black);
            }

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
        //Textbox Value Reset
        private void Reset()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            TxtPhone.Clear();
            TxtEmail.Clear();
            TxtPassword.Clear();

            BtnCreate.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;

            FillCustomerData();
        }
        //Fill in DataGrid itemSourec Customer
        private void FillCustomerData()
        {
            DgvCustomer.ItemsSource = _context.Customers.ToList();
        }
        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidationCheck())
            {
                MessageBox.Show("* olan yerləri boş buraxa bilməssiniz!");
                return;
            }

            //Create Customer
            Customer customer = new Customer
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Phone = TxtPhone.Text,
                Email = TxtEmail.Text,
                Password = TxtPassword.Password
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();
            MessageBox.Show("Müştəri Əlavə olundu");
            Reset();
        }

        //Update Customer
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

            _selectedCustomer.Name = TxtName.Text;
            _selectedCustomer.Surname = TxtSurname.Text;
            _selectedCustomer.Phone = TxtPhone.Text;
            _selectedCustomer.Email = TxtEmail.Text;
            _selectedCustomer.Password = TxtPassword.Password;
            
            _context.SaveChanges();
            MessageBox.Show("Müştəri Yeniləndi");
            Reset();
        }

        //Delete Customer
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult message = MessageBox.Show("Silməyə əminsinizmi!?", _selectedCustomer.ToString(), MessageBoxButton.OKCancel);

            if (message == MessageBoxResult.OK)
            {
                _context.Customers.Remove(_selectedCustomer);
                _context.SaveChanges();
                MessageBox.Show("Müştəri silindi");
                Reset();
            }
        }

        //Select Data in DataGrid
        private void DgvCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvCustomer.SelectedItem == null) return;

            _selectedCustomer = (Customer)DgvCustomer.SelectedItem;

            TxtName.Text = _selectedCustomer.Name;
            TxtSurname.Text = _selectedCustomer.Surname;
            TxtPhone.Text = _selectedCustomer.Phone;
            TxtEmail.Text = _selectedCustomer.Email;
            TxtPassword.Password = _selectedCustomer.Password;

            BtnCreate.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
            
        }
    }
}

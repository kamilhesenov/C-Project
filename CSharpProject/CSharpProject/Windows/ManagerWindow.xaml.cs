using CSharpProject.Data;
using CSharpProject.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace CSharpProject.Windows
{
   
    public partial class ManagerWindow : Window
    {
        private readonly LibrariyContext _context;
        private Manager _selectedManager;
        public ManagerWindow()
        {
            InitializeComponent();
            _context = new LibrariyContext();
            FillManagerData();
            Reset();
        }

        //Fill in DataGrid itemSourec Manager
        private void FillManagerData()
        {
            DgvManager.ItemsSource = _context.Managers.ToList();
        }

        //Check  Textbox Value
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

            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                LblEmail.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblEmail.Foreground = new SolidColorBrush(Colors.Black);
            }
            return hasError;
        }

        //Reset Textbox Value
        private void Reset()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            TxtEmail.Clear();

            BtnCreate.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;

            FillManagerData();
        }

        //Create Manager
       private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidationCheck())
            {
                MessageBox.Show("* olan yerləri boş buraxa bilməssiniz!");
                return;
            }

            Manager manager = new Manager
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Email = TxtEmail.Text
            };

            _context.Managers.Add(manager);
            _context.SaveChanges();
            MessageBox.Show("Manager Əlavə olundu");
            Reset();

        }
        //Select Data in DataGrid
        private void DgvManager_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvManager.SelectedItem == null) return;

            _selectedManager = (Manager)DgvManager.SelectedItem;

            TxtName.Text = _selectedManager.Name;
            TxtSurname.Text = _selectedManager.Surname;
            TxtEmail.Text = _selectedManager.Email;

            BtnCreate.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
            
        }
        //Update Manager
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidationCheck())
            {
                MessageBox.Show("* olan yerləri boş buraxa bilməssiniz!");
                return;
            }

            _selectedManager.Name = TxtName.Text;
            _selectedManager.Surname = TxtSurname.Text;
            _selectedManager.Email = TxtEmail.Text;
           
           _context.SaveChanges();
            MessageBox.Show("Manager Yeniləndi");
            Reset();
        }
        //Delete Manager
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult message = MessageBox.Show("Silməyə əminsinizmi!?", _selectedManager.ToString(), MessageBoxButton.OKCancel);

            if (message == MessageBoxResult.OK)
            {
                _context.Managers.Remove(_selectedManager);
                _context.SaveChanges();
                MessageBox.Show("Manager Silindi");
                Reset();
            }
        }
    }
}

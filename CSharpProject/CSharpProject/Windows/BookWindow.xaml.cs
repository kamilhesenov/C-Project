using CSharpProject.Data;
using CSharpProject.Models;
using System.Linq;
using System.Windows;
using System.Windows.Media;


namespace CSharpProject.Windows
{
    
    public partial class BookWindow : Window
    {
        private readonly LibrariyContext _context;
        private Book _selectedBook;
        public BookWindow()
        {
            InitializeComponent();
            _context = new LibrariyContext();
            FillBookData();
        }
        //Check Textbox Value
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

            return hasError;
        }

        //Reset Textbox Value
        private void Reset()
        {
            TxtName.Clear();
            TxtPrice.Clear();
            TxtQuantity.Clear();

            BtnCreate.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;

            FillBookData();
        }
        //Fill Book Data
        private void FillBookData()
        {
            DgvBook.ItemsSource = _context.Books.ToList();
        }
        
        //Book Create
        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidationCheck())
            {
                MessageBox.Show("* olan yerləri boş buraxa bilməssiniz!");
                return;
            }
            
            int quentityNumber;
            

            bool resultQuentity = int.TryParse(TxtQuantity.Text, out quentityNumber);

            if (resultQuentity == false)
            {
                MessageBox.Show("Miqdar rəqəm olmalıdır!");
                return;
            }

            int priceNumber;
            bool resultPrice = int.TryParse(TxtPrice.Text, out priceNumber);

            if (resultPrice == false)
            {
                MessageBox.Show("Qiymət rəqəm olmalıdır!");
                return;
            }

            Book book = new Book
            {
                Name = TxtName.Text,
                Quantity = quentityNumber,
                Price = priceNumber
            };

            _context.Books.Add(book);
            _context.SaveChanges();
            MessageBox.Show("Kitab Əlavə olundu");
            Reset();
            
        }
        //Book Update
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidationCheck())
            {
                MessageBox.Show("* olan yerləri boş buraxa bilməssiniz!");
                return;
            }

            int quentityNumber;


            bool resultQuentity = int.TryParse(TxtQuantity.Text, out quentityNumber);

            if (resultQuentity == false)
            {
                MessageBox.Show("Miqdar rəqəm olmalıdır!");
                return;
            }

            int priceNumber;
            bool resultPrice = int.TryParse(TxtPrice.Text, out priceNumber);

            if (resultPrice == false)
            {
                MessageBox.Show("Qiymət rəqəm olmalıdır!");
                return;
            }


            _selectedBook.Name = TxtName.Text;
            _selectedBook.Quantity = quentityNumber;
            _selectedBook.Price = priceNumber;
            

            
            _context.SaveChanges();
            MessageBox.Show("Kitab Yeniləndi");
            Reset();
        }
        //Book Delete
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult message = MessageBox.Show("Silməyə əminsinizmi!?", _selectedBook.ToString(), MessageBoxButton.OKCancel);

            if (message == MessageBoxResult.OK)
            {
                _context.Books.Remove(_selectedBook);
                _context.SaveChanges();
                MessageBox.Show("Kitab Silindi");
                Reset();
            }
        }
        //Select Data in DataGrid
        private void DgvBook_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (DgvBook.SelectedItem == null) return;
            _selectedBook = (Book)DgvBook.SelectedItem;

            TxtName.Text = _selectedBook.Name;
            TxtPrice.Text = _selectedBook.Price.ToString();
            TxtQuantity.Text = _selectedBook.Quantity.ToString();

            BtnCreate.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
            
        }
    }
}

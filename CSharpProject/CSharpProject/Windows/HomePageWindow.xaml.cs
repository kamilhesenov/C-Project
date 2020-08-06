using System.Windows;


namespace CSharpProject.Windows
{
    
    public partial class HomePageWindow : Window
    {
        public HomePageWindow()
        {
            InitializeComponent();
        }

        private void CreateManager_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow manager = new ManagerWindow();
            manager.ShowDialog();
        }

        private void CreateBook_Click(object sender, RoutedEventArgs e)
        {
            BookWindow book = new BookWindow();
            book.ShowDialog();
        }

        private void CreateCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow customerWindow = new CustomerWindow();
            customerWindow.ShowDialog();
        }
    }
}

using System.Windows;


namespace CSharpProject.Windows
{
    
    public partial class HomePageWindow : Window
    {
        public HomePageWindow()
        {
            InitializeComponent();
        }

        //Open ManegerWindow
        private void CreateManager_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow manager = new ManagerWindow();
            manager.ShowDialog();
        }

        //Open BookWindow
        private void CreateBook_Click(object sender, RoutedEventArgs e)
        {
            BookWindow book = new BookWindow();
            book.ShowDialog();
        }

        //Open CustomerWindow
        private void CreateCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow customerWindow = new CustomerWindow();
            customerWindow.ShowDialog();
        }

        //Open LoginWindow
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        }

        //Open ReportWindow
        private void Report_Click(object sender, RoutedEventArgs e)
        {
            RaportWindow raportWindow = new RaportWindow();
            raportWindow.ShowDialog();
        }
    }
}

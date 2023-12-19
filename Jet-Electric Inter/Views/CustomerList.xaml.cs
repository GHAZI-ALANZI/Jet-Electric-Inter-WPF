using Jet_Electric_DataAccessLayer.AppDbContext;
using System.Windows;
using System.Windows.Controls;

namespace Jet_Electric_Inter.Views
{
    /// <summary>
    /// Interaction logic for CustomerList.xaml
    /// </summary>
    public partial class CustomerList : UserControl
    {
        public CustomerList()
        {
            InitializeComponent();
            LoadData();
            PopupBox.Visibility = Visibility.Visible;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        void LoadData()
        {
            DataGrid.ItemsSource = new JetDbContext().Contacts.ToList();
        }

        private void PopUp_AddNewCustomer(object sender, RoutedEventArgs e)
        {

            TextBlock_TitleName.Visibility = Visibility.Collapsed;
            DataGrid.Visibility = Visibility.Collapsed;
            PopupBox.Visibility = Visibility.Collapsed;

            CustomerAddNew x = new CustomerAddNew();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
            PopupBoxWithClose.Visibility = Visibility.Visible;
        }

        private void PopUp_Close(object sender, RoutedEventArgs e)
        {
            UserPages.Children.Clear();
            PopupBoxWithClose.Visibility = Visibility.Hidden;

            LoadData();
            TextBlock_TitleName.Visibility = Visibility.Visible;
            DataGrid.Visibility = Visibility.Visible;
            PopupBox.Visibility = Visibility.Visible;
        }

        private void PopUp_EditCustomer(object sender, RoutedEventArgs e)
        {

            TextBlock_TitleName.Visibility = Visibility.Collapsed;
            DataGrid.Visibility = Visibility.Collapsed;
            PopupBox.Visibility = Visibility.Collapsed;

            CustomerEdit x = new CustomerEdit();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
            PopupBoxWithClose.Visibility = Visibility.Visible;
        }
    }
}

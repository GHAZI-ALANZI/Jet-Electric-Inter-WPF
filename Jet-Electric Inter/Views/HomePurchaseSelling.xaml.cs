using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Jet_Electric_Inter.Views
{
    /// <summary>
    /// Interaction logic for HomePurchaseSelling.xaml
    /// </summary>
    public partial class HomePurchaseSelling : UserControl
    {
        public HomePurchaseSelling()
        {
            InitializeComponent();
        }

        //Executing after loading window
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //worker = new BackgroundWorker();
            //worker.DoWork += Worker_DoWork;
            //worker.RunWorkerAsync();
        }


        #region main-buttons

        private void ButtonEmployees_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonProducts_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCompanies_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonProjects_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPurchaseSelling_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region socialbuttons

        // Social Buttons
        private void TwitterButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("http://twitter.com/");
        }

        private void ChatButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("http://twitter.com/");
        }

        private void EmailButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("mailto://gmail@gmail.com");
        }

        // Information Links
        private void TextBlock_WebOrdersMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("http://google.com");
        }
        #endregion

        private void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            CustomerAddNew x = new CustomerAddNew();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            SupplierAddNew x = new SupplierAddNew();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonUpdateCustomer_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            CustomerEdit x = new CustomerEdit();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonUpdateSupplier_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            SupplierEdit x = new SupplierEdit();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonAllCustomers_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            CustomerList x = new CustomerList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonAllSuppliers_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            SupplierList x = new SupplierList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonAllCOList_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            CustomerOrderList x = new CustomerOrderList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonAllPOList_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            PurchaseOrderList x = new PurchaseOrderList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonAddCO_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            CustomerOrderAdd x = new CustomerOrderAdd();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonAddPO_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            PurchaseOrderAdd x = new PurchaseOrderAdd();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

    }
}

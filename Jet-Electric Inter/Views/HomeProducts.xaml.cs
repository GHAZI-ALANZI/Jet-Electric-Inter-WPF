using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Jet_Electric_Inter.Views
{
    /// <summary>
    /// Interaction logic for HomeProducts.xaml
    /// </summary>
    public partial class HomeProducts : UserControl
    {
        public HomeProducts()
        {
            InitializeComponent();
        }

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
            Process.Start("http://twitter.com");
        }

        private void ChatButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("http://twitter.com");
        }

        private void EmailButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("mailto://gmail@gmail.com");
        }

        // Information Links
        private void TextBlock_WebOrdersMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("http://google.com/");
        }
        #endregion

        private void ButtonAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            ProductAddNew x = new ProductAddNew();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonUpdateProducts_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            ProductEdit x = new ProductEdit();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonPanelList_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            PanelList x = new PanelList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonPartList_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            PartList x = new PartList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void ButtonProductStock_Click(object sender, RoutedEventArgs e)
        {
            this.topgrid.Visibility = Visibility.Collapsed;
            this.mainscrollviewer.Visibility = Visibility.Collapsed;

            ProdStockList x = new ProdStockList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }


    }
}

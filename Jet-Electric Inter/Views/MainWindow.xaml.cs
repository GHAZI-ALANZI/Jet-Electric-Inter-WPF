﻿using Jet_Electric_Inter.Logic;
using MahApps.Metro.Controls;
using MaterialDesignThemes.Wpf;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace Jet_Electric_Inter.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Home x = new Home();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        #region diaglog-socialbuttons-informationlinks

        // About message dialog
        private void MenuPopupAboutButton_OnClick(object sender, RoutedEventArgs e)
        {
            var sMessageDialog = new MessageDialog
            {
                //Message = { Text = ((ButtonBase)sender).Content.ToString() }
                Message = { Text =
                    "Developed by\n" +
                    "\n Ghazi"

                }
            };

            DialogHost.Show(sMessageDialog, "RootDialog");
        }

        // Social Buttons
        private void TwitterButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://twitter.com/?lang=de");
        }

        private void ChatButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://twitter.com/?lang=de");
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

        private void TextBlock_FaxOrdersMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var sMessageDialog = new MessageDialog
            {
                Message = { Text = "Fax Orders Server is currently\n offline." }
            };

            DialogHost.Show(sMessageDialog, "RootDialog");
        }

        private void TextBlock_PhoneNumbersMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var sMessageDialog = new MessageDialog
            {
                Message = { Text =
                    "Important Phone Numbers\n" +
                    "\n1. Police: 15" +
                    "\n2. IIUI:   +92 51 901 9100" }
            };

            DialogHost.Show(sMessageDialog, "RootDialog");
        }
        #endregion


        #region treeitems
        private void TreeItem_ProductAdd_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ProductAddNew x = new ProductAddNew();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_ProductEdit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ProductEdit x = new ProductEdit();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_ProductPartList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PartList x = new PartList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_ProductPanelList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PanelList x = new PanelList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_CompaniesAdd_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CompanyAddNew x = new CompanyAddNew();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }
        private void TreeItem_CompaniesList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CompanyList x = new CompanyList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_Home_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Home x = new Home();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_EmployeeAdd_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            EmployeeAddNew x = new EmployeeAddNew();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_EmployeeList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            EmployeeList x = new EmployeeList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_SupplierAdd_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SupplierAddNew x = new SupplierAddNew();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_SupplierList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SupplierList x = new SupplierList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_CustomerAdd_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CustomerAddNew x = new CustomerAddNew();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_CustomerList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CustomerList x = new CustomerList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_PurchaseOrderAdd_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PurchaseOrderAdd x = new PurchaseOrderAdd();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_PurchaseOrderList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PurchaseOrderList x = new PurchaseOrderList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_CustomerOrderAdd_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CustomerOrderAdd x = new CustomerOrderAdd();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_CustomerOrderList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CustomerOrderList x = new CustomerOrderList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_EmployeeEdit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            EmployeeEdit x = new EmployeeEdit();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_CustomerEdit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CustomerEdit x = new CustomerEdit();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_SupplierEdit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SupplierEdit x = new SupplierEdit();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_CompaniesEdit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CompanyEdit x = new CompanyEdit();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_ProjectAdd_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ProjectAddNew x = new ProjectAddNew();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_ProjectEdit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ProjectEdit x = new ProjectEdit();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TreeItem_ProjectList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ProjectList x = new ProjectList();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        #endregion

        #region topbar
        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            //emp

            HomeEmployees x = new HomeEmployees();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TextBlock_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            //prod
            HomeProducts x = new HomeProducts();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TextBlock_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            //companies
            HomeCompanies x = new HomeCompanies();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TextBlock_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            //proj
            HomeProjects x = new HomeProjects();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }

        private void TextBlock_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            //purchase/selling
            HomePurchaseSelling x = new HomePurchaseSelling();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
        }
        #endregion
        private void MenuPopupLogoutButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LoggedInUser.Instance.RemoveData();
            Login x = new Login();
            x.Show();
            this.Close();
        }

    }
}

﻿using Jet_Electric_DataAccessLayer.Factories;
using Jet_Electric_DataAccessLayer.Models;
using System.Windows;
using System.Windows.Controls;

namespace Jet_Electric_Inter.Views
{
    /// <summary>
    /// Interaction logic for PurchaseOrderList.xaml
    /// </summary>
    public partial class PurchaseOrderList : UserControl
    {
        public PurchaseOrderList()
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
            List<Product_PurchaseOrderBT> proPurchaseBTList = new Product_PurchaseOrderBTFactory().SelectAll();
            DataGrid.ItemsSource = proPurchaseBTList;
            //proPurchaseBTList.FirstOrDefault().PurchaseOrder.Contact.Phone
        }

        private void PopUp_AddNewCompany(object sender, RoutedEventArgs e)
        {



            TextBlock_TitleName.Visibility = Visibility.Collapsed;
            DataGrid.Visibility = Visibility.Collapsed;
            PopupBox.Visibility = Visibility.Collapsed;

            PurchaseOrderAdd x = new PurchaseOrderAdd();
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

    }
}

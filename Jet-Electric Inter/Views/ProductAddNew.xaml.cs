﻿using Jet_Electric_DataAccessLayer.Factories;
using Jet_Electric_DataAccessLayer.Models;
using MaterialDesignThemes.Wpf;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ViewModels;
using Panel = Jet_Electric_DataAccessLayer.Models.Panel;

namespace Jet_Electric_Inter.Views
{
    /// <summary>
    /// Interaction logic for ProductAddNew.xaml
    /// </summary>
    public partial class ProductAddNew : UserControl
    {
        ProductViewModel _vm;
        BackgroundWorker worker;
        public ProductAddNew()
        {
            InitializeComponent();
            _vm = new ProductViewModel();
            this.DataContext = _vm;
        }

        //Executing after loading window, refer to XAML
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerAsync();
        }

        void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Make> mklist = new MakeFactory().SelectAll();
            List<Jet_Electric_DataAccessLayer.Models.Type> paneltypelist = new TypeFactory().SelectAll();
            List<SizeType> szlist = new SizeTypeFactory().SelectAll();
            List<PanelShellGradeProtection> shellgradelist = new PanelShellGradeProtectionFactory().SelectAll();
            List<Certification> certlist = new CertificationFactory().SelectAll();
            List<PaType> parttypelist = new PaTypeFactory().SelectAll();
            List<Location> locationlist = new LocationFactory().SelectAll();

            this.Dispatcher.Invoke(() =>
            {
                // Generic
                MakeComboBox.ItemsSource = mklist;
                MakeComboBox.DisplayMemberPath = "Name";
                MakeComboBox.SelectedValuePath = "ID";

                //Panel Type
                PanelTypeComboBox.ItemsSource = paneltypelist;
                PanelTypeComboBox.DisplayMemberPath = "Description";
                PanelTypeComboBox.SelectedValuePath = "ID";

                SizeComboBox.ItemsSource = szlist;
                SizeComboBox.DisplayMemberPath = "Description";
                SizeComboBox.SelectedValuePath = "ID";

                PanelIPNumberComboBox.ItemsSource = shellgradelist;
                PanelIPNumberComboBox.DisplayMemberPath = "IPNum";
                PanelIPNumberComboBox.SelectedValuePath = "ID";

                CertComboBox.ItemsSource = certlist;
                CertComboBox.DisplayMemberPath = "Name";
                CertComboBox.SelectedValuePath = "ID";

                //Part Type
                PartTypeComboBox.ItemsSource = parttypelist;
                PartTypeComboBox.DisplayMemberPath = "Name";
                PartTypeComboBox.SelectedValuePath = "ID";

                //Location
                LocationComboBox.ItemsSource = locationlist;
                LocationComboBox.DisplayMemberPath = "Name";
                LocationComboBox.SelectedValuePath = "ID";
            });
        }

        private void P_Panel_Checked(object sender, RoutedEventArgs e)
        {
            //Panel
            TxtBxStackPanel4.Visibility = Visibility.Collapsed;

            //Part
            TxtBxStackPanel0.Visibility = Visibility.Visible;
            TxtBxStackPanel1.Visibility = Visibility.Visible;
            TxtBxStackPanel2.Visibility = Visibility.Visible;
            TxtBxStackPanel3.Visibility = Visibility.Visible;
        }

        private void P_Product_Checked(object sender, RoutedEventArgs e)
        {
            //Panel
            TxtBxStackPanel4.Visibility = Visibility.Visible;

            //Part
            TxtBxStackPanel0.Visibility = Visibility.Collapsed;
            TxtBxStackPanel1.Visibility = Visibility.Collapsed;
            TxtBxStackPanel2.Visibility = Visibility.Collapsed;
            TxtBxStackPanel3.Visibility = Visibility.Collapsed;
        }

        private void ForceValidation()
        {
            NameTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            SerialNoTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            StockLevelTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }


        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            #region validation 
            ForceValidation();
            if (Validation.GetHasError(NameTextBox) || Validation.GetHasError(SerialNoTextBox) || Validation.GetHasError(StockLevelTextBox))
            {
                var sMessageDialog = new MessageDialog
                {
                    Message = { Text =
                    "ERROR: Fill required fields!" }
                };

                DialogHost.Show(sMessageDialog, "RootDialog");
                return;
            }
            else if (!(bool)P_Panel.IsChecked && !(bool)P_Part.IsChecked)
            {
                var sMessageDialog = new MessageDialog
                {
                    Message = { Text =
                    "ERROR: Select either part or panel!" }
                };

                DialogHost.Show(sMessageDialog, "RootDialog");
                return;
            }
            else if ((bool)P_Panel.IsChecked)
            {
                if (MakeComboBox.SelectedValue == null ||
                    LocationComboBox.SelectedValue == null ||
                    PanelTypeComboBox.SelectedValue == null ||
                    SizeComboBox.SelectedValue == null ||
                    PanelIPNumberComboBox.SelectedValue == null ||
                    CertComboBox.SelectedValue == null
                    )
                {
                    var sMessageDialog = new MessageDialog
                    {
                        Message = { Text =
                    "ERROR: Select all fields!" }
                    };

                    DialogHost.Show(sMessageDialog, "RootDialog");
                    return;
                }
            }
            else if ((bool)P_Part.IsChecked)
            {
                if (MakeComboBox.SelectedValue == null ||
                    LocationComboBox.SelectedValue == null ||
                    PartTypeComboBox.SelectedValue == null
                    )
                {
                    var sMessageDialog = new MessageDialog
                    {
                        Message = { Text =
                    "ERROR: Select all fields!" }
                    };

                    DialogHost.Show(sMessageDialog, "RootDialog");
                    return;
                }
            }

            #endregion

            if ((bool)P_Panel.IsChecked)
            {
                Panel panel = new Panel()
                {
                    Name = NameTextBox.Text,
                    SerialNo = SerialNoTextBox.Text,
                    MakeID = int.Parse(MakeComboBox.SelectedValue.ToString()),
                    TypeID = int.Parse(PanelTypeComboBox.SelectedValue.ToString()),
                    SizeTypeID = int.Parse(SizeComboBox.SelectedValue.ToString()),
                    PanelShellGradeProtectionIPNumber = int.Parse(PanelIPNumberComboBox.SelectedValue.ToString()),
                    CertificationID = int.Parse(CertComboBox.SelectedValue.ToString())
                };

                Product incomingNewProduct = new Panel();
                incomingNewProduct = panel;
                AddProd(incomingNewProduct);
                AddProdToLocation(incomingNewProduct,
                    int.Parse(StockLevelTextBox.Text),
                    int.Parse(LocationComboBox.SelectedValue.ToString()));
            }

            if ((bool)P_Part.IsChecked)
            {
                Part part = new Part()
                {
                    Name = NameTextBox.Text,
                    SerialNo = SerialNoTextBox.Text,
                    MakeID = int.Parse(MakeComboBox.SelectedValue.ToString()),

                    PaTypeID = int.Parse(PartTypeComboBox.SelectedValue.ToString())
                };

                Product incomingNewProduct = new Part();
                incomingNewProduct = part;
                AddProd(incomingNewProduct);
                AddProdToLocation(incomingNewProduct,
                    int.Parse(StockLevelTextBox.Text),
                    int.Parse(LocationComboBox.SelectedValue.ToString()));
            }

            ClearButton_Click(null, null);
        }

        private void AddProdToLocation(Product prod, int stockLevel, int locID)
        {
            var inven = new Inventory()
            {
                ID = prod.ID,
                StockLevel = stockLevel,
                LocationID = locID,
            };
            new InventoryFactory().InsertInventory(inven);
        }

        private void AddProd(Product incomingNewProduct)
        {
            if (new ProductFactory().InsertProduct(incomingNewProduct))
            {
                var sMessageDialog = new MessageDialog
                {
                    Message = { Text = "Added succesfully!" }
                };
                DialogHost.Show(sMessageDialog, "RootDialog");
                return;
            }
            else
            {
                var sMessageDialog = new MessageDialog
                {
                    Message = { Text = "Couldn't Insert!" }
                };
                DialogHost.Show(sMessageDialog, "RootDialog");
                return;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            NameTextBox.Clear();
            StockLevelTextBox.Clear();
            SerialNoTextBox.Clear();

            MakeComboBox.SelectedItem = null;
            CertComboBox.SelectedItem = null;
            PanelIPNumberComboBox.SelectedItem = null;
            SizeComboBox.SelectedItem = null;
            PanelTypeComboBox.SelectedItem = null;
            PartTypeComboBox.SelectedItem = null;
            LocationComboBox.SelectedItem = null;
        }

    }
}

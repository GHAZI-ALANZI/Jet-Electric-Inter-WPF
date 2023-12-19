using System.Windows.Controls;

namespace Jet_Electric_Inter.Views
{

    class ProductItem
    {
        public int Quantity { get; set; }
        public int ProductID { get; set; }

        public ProductItem()
        {
            this.Quantity = 0;
            this.ProductID = 0;
        }
    }


    /// <summary>
    /// Interaction logic for PurchaseOrderAdd.xaml
    /// </summary>
    public partial class PurchaseOrderAdd : UserControl
    {
        public PurchaseOrderAdd()
        {
            InitializeComponent();
        }
    }
}

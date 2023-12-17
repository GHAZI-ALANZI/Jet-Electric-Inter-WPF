namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Product_PurchaseOrderBT
    {
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public int PurchaseOrderID { get; set; }

        public virtual Product Product { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}

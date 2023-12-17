namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class PurchaseOrder
    {

        public PurchaseOrder()
        {
            this.Product_PurchaseOrderBT = new HashSet<Product_PurchaseOrderBT>();
        }

        public int ID { get; set; }
        public System.DateTime PODate { get; set; }
        public int ContactID { get; set; }
        public int OrderStatusID { get; set; }
        public int EmployeeID { get; set; }
        public virtual ICollection<Product_PurchaseOrderBT> Product_PurchaseOrderBT { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual Employee Employee { get; set; }
    }
}

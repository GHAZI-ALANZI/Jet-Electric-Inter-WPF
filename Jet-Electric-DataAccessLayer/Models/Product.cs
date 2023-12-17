namespace Jet_Electric_DataAccessLayer.Models
{
    public abstract partial class Product
    {

        public Product()
        {
            this.Product_CustomerOrderBT = new HashSet<Product_CustomerOrderBT>();
            this.Product_PurchaseOrderBT = new HashSet<Product_PurchaseOrderBT>();
        }

        public int ID { get; set; }
        public string SerialNo { get; set; }
        public string Name { get; set; }
        public int MakeID { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Make Make { get; set; }
        public virtual ICollection<Product_CustomerOrderBT> Product_CustomerOrderBT { get; set; }
        public virtual ICollection<Product_PurchaseOrderBT> Product_PurchaseOrderBT { get; set; }
    }
}

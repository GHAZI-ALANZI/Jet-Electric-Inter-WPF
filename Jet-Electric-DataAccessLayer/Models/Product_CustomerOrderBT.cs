namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Product_CustomerOrderBT
    {
        public int ProductID { get; set; }
        public int CustomerOrderID { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual CustomerOrder CustomerOrder { get; set; }
    }
}

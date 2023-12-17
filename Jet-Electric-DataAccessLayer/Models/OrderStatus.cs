namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class OrderStatus
    {

        public OrderStatus()
        {
            this.CustomerOrders = new HashSet<CustomerOrder>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}

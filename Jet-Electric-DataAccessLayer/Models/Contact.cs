namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Contact
    {

        public Contact()
        {
            this.CustomerOrders = new HashSet<CustomerOrder>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}

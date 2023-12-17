namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class CustomerOrder
    {
        public CustomerOrder()
        {
            this.Product_CustomerOrderBT = new HashSet<Product_CustomerOrderBT>();
            this.Projects = new HashSet<Project>();
        }

        public int ID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public int ContactID { get; set; }
        public int OrderStatusID { get; set; }
        public int EmployeeID { get; set; }
        public virtual ICollection<Product_CustomerOrderBT> Product_CustomerOrderBT { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}

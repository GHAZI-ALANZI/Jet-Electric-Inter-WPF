namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Employee
    {

        public Employee()
        {
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
            this.CustomerOrders = new HashSet<CustomerOrder>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public System.DateTime JoinDate { get; set; }
        public string Address { get; set; }
        public int DesignationID { get; set; }
        public int EmployeeStatusID { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual EmployeeStatus EmployeeStatus { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
    }
}

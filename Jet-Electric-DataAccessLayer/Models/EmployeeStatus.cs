namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class EmployeeStatus
    {

        public EmployeeStatus()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}

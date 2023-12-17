namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Designation
    {

        public Designation()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}

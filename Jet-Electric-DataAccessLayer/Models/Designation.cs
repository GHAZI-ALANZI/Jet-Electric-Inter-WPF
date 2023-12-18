namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Designation
    {



        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}

namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Project
    {

        public Project()
        {
            this.Panel_ProjectBT = new HashSet<Panel_ProjectBT>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public System.DateTime DeliveyDate { get; set; }
        public int CustomerOrderID { get; set; }
        public virtual ICollection<Panel_ProjectBT> Panel_ProjectBT { get; set; }
        public virtual CustomerOrder CustomerOrder { get; set; }
    }
}

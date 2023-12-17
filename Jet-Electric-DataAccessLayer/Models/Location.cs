namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Location
    {

        public Location()
        {
            this.Inventories = new HashSet<Inventory>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}

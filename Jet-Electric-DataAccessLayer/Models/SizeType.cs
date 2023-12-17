namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class SizeType
    {

        public SizeType()
        {
            this.Panels = new HashSet<Panel>();
        }
        public int ID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Panel> Panels { get; set; }
    }
}

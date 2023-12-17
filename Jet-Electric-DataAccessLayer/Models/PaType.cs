namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class PaType
    {

        public PaType()
        {
            this.Parts = new HashSet<Part>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
    }
}

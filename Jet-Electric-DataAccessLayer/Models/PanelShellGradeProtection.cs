namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class PanelShellGradeProtection
    {

        public PanelShellGradeProtection()
        {
            this.Panels = new HashSet<Panel>();
        }

        public int ID { get; set; }
        public string IPNum { get; set; }
        public string DescriptionSolids { get; set; }
        public string DescriptionLiquids { get; set; }
        public virtual ICollection<Panel> Panels { get; set; }
    }
}

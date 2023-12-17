namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Panel : Product
    {

        public Panel()
        {
            this.Panel_ProjectBT = new HashSet<Panel_ProjectBT>();
        }

        public int PanelShellGradeProtectionIPNumber { get; set; }
        public int SizeTypeID { get; set; }
        public int CertificationID { get; set; }
        public int TypeID { get; set; }
        public virtual PanelShellGradeProtection PanelShellGradeProtection { get; set; }
        public virtual SizeType SizeType { get; set; }
        public virtual Certification Certification { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<Panel_ProjectBT> Panel_ProjectBT { get; set; }
    }
}

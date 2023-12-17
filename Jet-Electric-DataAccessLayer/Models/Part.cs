namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Part : Product
    {
        public int PaTypeID { get; set; }

        public virtual PaType PaType { get; set; }
    }
}

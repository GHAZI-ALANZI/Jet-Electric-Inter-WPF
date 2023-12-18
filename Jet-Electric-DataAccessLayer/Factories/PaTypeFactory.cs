// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class PaTypeFactory
    {
        PaTypeDA patypeDa;

        public PaTypeFactory()
        {
            patypeDa = new PaTypeDA();
        }

        public List<PaType> SelectAll()
        {
            return patypeDa.SelectAll();
        }

        public bool InsertPaType(PaType patype)
        {
            return patypeDa.InsertPaType(patype);
        }
    }
}

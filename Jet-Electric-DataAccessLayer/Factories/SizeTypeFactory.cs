// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class SizeTypeFactory
    {
        SizeTypeDA sztypeDa;

        public SizeTypeFactory()
        {
            sztypeDa = new SizeTypeDA();
        }

        public List<SizeType> SelectAll()
        {
            return sztypeDa.SelectAll();
        }

        public bool InsertSizeType(SizeType sztype)
        {
            return sztypeDa.InsertSizeType(sztype);
        }
    }
}

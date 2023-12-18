// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class MakeFactory
    {
        MakeDA mkDa;

        public MakeFactory()
        {
            mkDa = new MakeDA();
        }

        public List<Make> SelectAll()
        {
            return mkDa.SelectAll();
        }

        public bool InsertMake(Make mk)
        {
            return mkDa.InsertMake(mk);
        }
    }
}

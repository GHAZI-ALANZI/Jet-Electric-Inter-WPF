// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class LocationFactory
    {
        LocationDA locDa;

        public LocationFactory()
        {
            locDa = new LocationDA();
        }

        public List<Location> SelectAll()
        {
            return locDa.SelectAll();
        }

        public bool InsertLocation(Location desig)
        {
            return locDa.InsertLocation(desig);
        }
    }
}

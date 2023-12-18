// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class DesignationFactory
    {
        DesignationDA desigDa;

        public DesignationFactory()
        {
            desigDa = new DesignationDA();
        }

        public List<Designation> SelectAll()
        {
            return desigDa.SelectAll();
        }

        public bool InsertDesignation(Designation desig)
        {
            return desigDa.InsertDesignation(desig);
        }
    }
}

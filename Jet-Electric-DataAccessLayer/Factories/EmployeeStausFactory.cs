// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class EmployeeStatusFactory
    {
        EmployeeStatusDA empStatusDa;

        public EmployeeStatusFactory()
        {
            empStatusDa = new EmployeeStatusDA();
        }

        public List<EmployeeStatus> SelectAll()
        {
            return empStatusDa.SelectAll();
        }

        public bool InsertEmployeeStatus(EmployeeStatus desig)
        {
            return empStatusDa.InsertEmployeeStatus(desig);
        }
    }
}

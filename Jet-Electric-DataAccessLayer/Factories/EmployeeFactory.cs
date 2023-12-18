// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class EmployeeFactory
    {
        EmployeeDA empDa;

        public EmployeeFactory()
        {
            empDa = new EmployeeDA();
        }

        public List<Employee> SelectAll()
        {
            return empDa.SelectAll();
        }

        public List<Employee> SelectByDesignation(int id)
        {
            return empDa.SelectByDesignation(id);
        }

        public bool InsertEmployee(Employee emp)
        {
            return empDa.InsertEmployee(emp);
        }

        public bool Update(int id, string firstname, string lastname, string phone, string passport, DateTime joindate, string address, int desigid, int statusid)
        {
            return empDa.Update(id, firstname, lastname, phone, passport, joindate, address, desigid, statusid);
        }
    }
}

using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class EmployeeDA
    {
        JetDbContext db;

        public EmployeeDA()
        {
            db = new JetDbContext();
        }

        public List<Employee> SelectAll()
        {
            return db.Employees.ToList();
        }

        public List<Employee> SelectByDesignation(int id)
        {
            var emplist = db.Employees.Where(x => x.DesignationID == id).ToList();

            foreach (var row in emplist)
                row.FirstName = row.FirstName + " " + row.LastName;

            return emplist;
        }


        public bool InsertEmployee(Employee emp)
        {
            db.Employees.Add(emp);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var emp = db.Employees.Where(x => x.ID == id).FirstOrDefault();
            if (emp != null)
            {
                db.Employees.Remove(emp);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string firstname, string lastname, string phone, string passport, DateTime joindate, string address, int desigid, int statusid)
        {
            var emp = db.Employees.Where(x => x.ID == id).FirstOrDefault();
            if (emp != null)
            {
                emp.FirstName = firstname;
                emp.LastName = lastname;
                emp.Phone = phone;
                emp.Passport = passport;
                emp.JoinDate = joindate;
                emp.Address = address;
                emp.DesignationID = desigid;
                emp.EmployeeStatusID = statusid;
            }
            return db.SaveChanges() > 0 ? true : false;
        }

    }
}

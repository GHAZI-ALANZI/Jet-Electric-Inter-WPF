using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class DesignationDA
    {
        JetDbContext db;

        public DesignationDA()
        {
            db = new JetDbContext();
        }

        public List<Designation> SelectAll()
        {
            return db.Designations.ToList();
        }

        public bool InsertDesignation(Designation desig)
        {
            db.Designations.Add(desig);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var desig = db.Designations.Where(x => x.ID == id).FirstOrDefault();
            if (desig != null)
            {
                db.Designations.Remove(desig);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string name)
        {
            var desig = db.Designations.Where(x => x.ID == id).FirstOrDefault();
            if (desig != null)
            {
                desig.Name = name;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

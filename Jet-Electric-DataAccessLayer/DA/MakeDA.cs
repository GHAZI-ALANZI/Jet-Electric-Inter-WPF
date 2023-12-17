using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class MakeDA
    {
        JetDbContext db;

        public MakeDA()
        {
            db = new JetDbContext();
        }

        public List<Make> SelectAll()
        {
            return db.Makes.ToList();
        }

        public bool InsertMake(Make mk)
        {
            db.Makes.Add(mk);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var mk = db.Makes.Where(x => x.ID == id).FirstOrDefault();
            if (mk != null)
            {
                db.Makes.Remove(mk);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string name)
        {
            var mk = db.Makes.Where(x => x.ID == id).FirstOrDefault();
            if (mk != null)
            {
                mk.Name = name;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

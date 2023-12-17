using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class PaTypeDA
    {
        JetDbContext db;

        public PaTypeDA()
        {
            db = new JetDbContext();
        }

        public List<PaType> SelectAll()
        {
            return db.PaTypes.ToList();
        }

        public bool InsertPaType(PaType patype)
        {
            db.PaTypes.Add(patype);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var patype = db.PaTypes.Where(x => x.ID == id).FirstOrDefault();
            if (patype != null)
            {
                db.PaTypes.Remove(patype);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string name)
        {
            var patype = db.PaTypes.Where(x => x.ID == id).FirstOrDefault();
            if (patype != null)
            {
                patype.Name = name;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

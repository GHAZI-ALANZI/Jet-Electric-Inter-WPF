using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class SizeTypeDA
    {
        JetDbContext db;

        public SizeTypeDA()
        {
            db = new JetDbContext();
        }

        public List<SizeType> SelectAll()
        {
            return db.SizeTypes.ToList();
        }

        public bool InsertSizeType(SizeType sztype)
        {
            db.SizeTypes.Add(sztype);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var sztype = db.SizeTypes.Where(x => x.ID == id).FirstOrDefault();
            if (sztype != null)
            {
                db.SizeTypes.Remove(sztype);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string descrip)
        {
            var sztype = db.SizeTypes.Where(x => x.ID == id).FirstOrDefault();
            if (sztype != null)
            {
                sztype.Description = descrip;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

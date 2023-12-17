using Jet_Electric_DataAccessLayer.AppDbContext;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class TypeDA
    {
        JetDbContext db;

        public TypeDA()
        {
            db = new JetDbContext();
        }

        public List<Models.Type> SelectAll()
        {
            return db.Types.ToList();
        }

        public bool InsertType(Models.Type type)
        {
            db.Types.Add(type);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var type = db.Types.Where(x => x.ID == id).FirstOrDefault();
            if (type != null)
            {
                db.Types.Remove(type);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string descrip)
        {
            var type = db.Types.Where(x => x.ID == id).FirstOrDefault();
            if (type != null)
            {
                type.Description = descrip;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class LocationDA
    {
        JetDbContext db;

        public LocationDA()
        {
            db = new JetDbContext();
        }

        public List<Location> SelectAll()
        {
            return db.Locations.ToList();
        }

        public bool InsertLocation(Location loc)
        {
            db.Locations.Add(loc);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var desig = db.Locations.Where(x => x.ID == id).FirstOrDefault();
            if (desig != null)
            {
                db.Locations.Remove(desig);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string name)
        {
            var loc = db.Locations.Where(x => x.ID == id).FirstOrDefault();
            if (loc != null)
            {
                loc.Name = name;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

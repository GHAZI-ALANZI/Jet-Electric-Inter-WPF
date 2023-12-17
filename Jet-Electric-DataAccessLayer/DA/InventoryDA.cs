using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class InventoryDA
    {
        JetDbContext db;

        public InventoryDA()
        {
            db = new JetDbContext();
        }

        public List<Inventory> SelectAll()
        {
            return db.Inventories.ToList();
        }

        public bool InsertInventory(Inventory inven)
        {
            db.Inventories.Add(inven);
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, int stocklevel, int locID)
        {
            var inven = db.Inventories.Where(x => x.ID == id).FirstOrDefault();
            if (inven != null)
            {
                inven.LocationID = locID;
                inven.StockLevel = stocklevel;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

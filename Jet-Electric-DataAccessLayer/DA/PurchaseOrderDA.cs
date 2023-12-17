using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class PurchaseOrderDA
    {
        JetDbContext db;

        public PurchaseOrderDA()
        {
            db = new JetDbContext();
        }

        public List<PurchaseOrder> SelectAll()
        {
            return db.PurchaseOrders.ToList();
        }

        public bool InsertPurchaseOrder(PurchaseOrder po)
        {
            db.PurchaseOrders.Add(po);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var po = db.PurchaseOrders.Where(x => x.ID == id).FirstOrDefault();
            if (po != null)
            {
                db.PurchaseOrders.Remove(po);
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

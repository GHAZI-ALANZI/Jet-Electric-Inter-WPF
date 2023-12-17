using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class CustomerOrderDA
    {
        JetDbContext db;

        public CustomerOrderDA()
        {
            db = new JetDbContext();
        }

        public List<CustomerOrder> SelectAll()
        {
            return db.CustomerOrders.ToList();
        }

        public bool InsertCustomerOrder(CustomerOrder co)
        {
            db.CustomerOrders.Add(co);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var po = db.CustomerOrders.Where(x => x.ID == id).FirstOrDefault();
            if (po != null)
            {
                db.CustomerOrders.Remove(po);
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

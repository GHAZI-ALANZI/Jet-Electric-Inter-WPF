using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class OrderStatusDA
    {
        JetDbContext db;

        public OrderStatusDA()
        {
            db = new JetDbContext();
        }

        public List<OrderStatus> SelectAll()
        {
            return db.OrderStatus.ToList();
        }

        public bool InsertOrderStatus(OrderStatus con)
        {
            db.OrderStatus.Add(con);
            return db.SaveChanges() > 0 ? true : false;
        }



        public bool Update(int id, string name)
        {
            var con = db.OrderStatus.Where(x => x.ID == id).FirstOrDefault();
            if (con != null)
            {
                con.Name = name;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

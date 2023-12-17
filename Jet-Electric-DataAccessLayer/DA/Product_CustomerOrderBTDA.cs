using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class Product_CustomerOrderBTDA
    {
        JetDbContext db;

        public Product_CustomerOrderBTDA()
        {
            db = new JetDbContext();
        }

        public List<Product_CustomerOrderBT> SelectAll()
        {
            return db.Product_CustomerOrderBT.ToList();
        }

        public bool InsertProduct_CustomerOrderBT(Product_CustomerOrderBT productCustBT)
        {
            db.Product_CustomerOrderBT.Add(productCustBT);
            return db.SaveChanges() > 0 ? true : false;
        }

    }
}

using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class Product_PurchaseOrderBTDA
    {
        JetDbContext db;

        public Product_PurchaseOrderBTDA()
        {
            db = new JetDbContext();
        }

        public List<Product_PurchaseOrderBT> SelectAll()
        {
            return db.Product_PurchaseOrderBT.ToList();
        }

        public bool InsertProduct_PurchaseOrderBT(Product_PurchaseOrderBT productPurchaseBT)
        {
            db.Product_PurchaseOrderBT.Add(productPurchaseBT);
            return db.SaveChanges() > 0 ? true : false;
        }

    }
}

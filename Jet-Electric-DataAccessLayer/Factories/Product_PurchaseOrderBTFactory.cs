// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class Product_PurchaseOrderBTFactory
    {
        Product_PurchaseOrderBTDA productPurchaseBTDa;

        public Product_PurchaseOrderBTFactory()
        {
            productPurchaseBTDa = new Product_PurchaseOrderBTDA();
        }

        public List<Product_PurchaseOrderBT> SelectAll()
        {
            return productPurchaseBTDa.SelectAll();
        }

        public bool InsertProduct_PurchaseOrderBT(Product_PurchaseOrderBT productPurchaseBT)
        {
            return productPurchaseBTDa.InsertProduct_PurchaseOrderBT(productPurchaseBT);
        }
    }
}

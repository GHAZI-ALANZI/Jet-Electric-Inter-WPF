// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class Product_CustomerOrderBTFactory
    {
        Product_CustomerOrderBTDA productCustBTDa;

        public Product_CustomerOrderBTFactory()
        {
            productCustBTDa = new Product_CustomerOrderBTDA();
        }

        public List<Product_CustomerOrderBT> SelectAll()
        {
            return productCustBTDa.SelectAll();
        }

        public bool InsertProduct_CustomerOrderBT(Product_CustomerOrderBT productPurchaseBT)
        {
            return productCustBTDa.InsertProduct_CustomerOrderBT(productPurchaseBT);
        }
    }
}

// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class ProductFactory
    {
        ProductDA prodDa;

        public ProductFactory()
        {
            prodDa = new ProductDA();
        }

        public List<Product> SelectAll()
        {
            return prodDa.SelectAll();
        }

        public List<Part> SelectAllPart()
        {
            return prodDa.SelectAllPart();
        }

        public List<Panel> SelectAllPanel()
        {
            return prodDa.SelectAllPanel();
        }

        public bool InsertProduct(Product prod)
        {
            return prodDa.InsertProduct(prod);
        }

        public bool Update(int id, string serialno, string name, int makeid)
        {
            return prodDa.Update(id, serialno, name, makeid);
        }
    }
}

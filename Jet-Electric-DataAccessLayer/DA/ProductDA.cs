using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;
//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class ProductDA
    {
        JetDbContext db;

        public ProductDA()
        {
            db = new JetDbContext();
        }

        public List<Product> SelectAll()
        {
            return db.Products.ToList();
        }

        public bool InsertProduct(Product prod)
        {
            db.Products.Add(prod);
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string serialno, string name, int makeid)
        {
            var prod = db.Products.Where(x => x.ID == id).FirstOrDefault();
            if (prod != null)
            {
                prod.SerialNo = serialno;
                prod.Name = name;
                prod.MakeID = makeid;
            }
            return db.SaveChanges() > 0 ? true : false;
        }



        public List<Part> SelectAllPart()
        {
            return db.Products.OfType<Part>().ToList();
        }

        public List<Panel> SelectAllPanel()
        {
            return db.Products.OfType<Panel>().ToList();
        }

    }
}

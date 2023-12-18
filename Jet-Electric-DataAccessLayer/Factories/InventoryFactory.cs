// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class InventoryFactory
    {
        InventoryDA invenDa;

        public InventoryFactory()
        {
            invenDa = new InventoryDA();
        }

        public List<Inventory> SelectAll()
        {
            return invenDa.SelectAll();
        }

        public bool InsertInventory(Inventory inven)
        {
            return invenDa.InsertInventory(inven);
        }

        public bool Update(int id, int stocklevel, int locID)
        {
            return invenDa.Update(id, stocklevel, locID);
        }
    }
}

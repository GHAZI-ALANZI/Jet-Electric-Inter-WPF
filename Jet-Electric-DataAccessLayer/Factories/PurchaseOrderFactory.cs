// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class PurchaseOrderFactory
    {
        PurchaseOrderDA poDa;

        public PurchaseOrderFactory()
        {
            poDa = new PurchaseOrderDA();
        }

        public List<PurchaseOrder> SelectAll()
        {
            return poDa.SelectAll();
        }

        public bool InsertPurchaseOrder(PurchaseOrder po)
        {
            return poDa.InsertPurchaseOrder(po);
        }
    }
}

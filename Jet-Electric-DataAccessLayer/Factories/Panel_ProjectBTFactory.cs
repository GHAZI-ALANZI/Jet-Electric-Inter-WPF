// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class Panel_ProjectBTFactory
    {
        Panel_ProjectBTDA panelProjBTDa;

        public Panel_ProjectBTFactory()
        {
            panelProjBTDa = new Panel_ProjectBTDA();
        }

        public List<Panel_ProjectBT> SelectAll()
        {
            return panelProjBTDa.SelectAll();
        }

        public bool InsertPanel_ProjectBT(Panel_ProjectBT productPurchaseBT)
        {
            return panelProjBTDa.InsertPanel_ProjectBT(productPurchaseBT);
        }
    }
}

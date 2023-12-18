// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class PanelShellGradeProtectionFactory
    {
        PanelShellGradeProtectionDA pgradeDa;

        public PanelShellGradeProtectionFactory()
        {
            pgradeDa = new PanelShellGradeProtectionDA();
        }

        public List<PanelShellGradeProtection> SelectAll()
        {
            return pgradeDa.SelectAll();
        }

        public bool InsertPanelShellGradeProtection(PanelShellGradeProtection pgrade)
        {
            return pgradeDa.InsertPanelShellGradeProtection(pgrade);
        }
    }
}

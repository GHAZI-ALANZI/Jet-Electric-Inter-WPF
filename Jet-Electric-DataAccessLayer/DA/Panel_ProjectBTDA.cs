using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class Panel_ProjectBTDA
    {
        JetDbContext db;

        public Panel_ProjectBTDA()
        {
            db = new JetDbContext();
        }

        public List<Panel_ProjectBT> SelectAll()
        {
            return db.Panel_ProjectBT.ToList();
        }

        public bool InsertPanel_ProjectBT(Panel_ProjectBT panelProjBT)
        {
            db.Panel_ProjectBT.Add(panelProjBT);
            return db.SaveChanges() > 0 ? true : false;
        }

    }
}

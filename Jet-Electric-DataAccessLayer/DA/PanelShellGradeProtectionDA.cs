using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class PanelShellGradeProtectionDA
    {
        JetDbContext db;

        public PanelShellGradeProtectionDA()
        {
            db = new JetDbContext();
        }

        public List<PanelShellGradeProtection> SelectAll()
        {
            return db.PanelShellGradeProtections.ToList();
        }

        public bool InsertPanelShellGradeProtection(PanelShellGradeProtection pgrade)
        {
            db.PanelShellGradeProtections.Add(pgrade);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var pgrade = db.PanelShellGradeProtections.Where(x => x.ID == id).FirstOrDefault();
            if (pgrade != null)
            {
                db.PanelShellGradeProtections.Remove(pgrade);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string ipnum, string desLiq, string desSol)
        {
            var pgrade = db.PanelShellGradeProtections.Where(x => x.ID == id).FirstOrDefault();
            if (pgrade != null)
            {
                pgrade.IPNum = ipnum;
                pgrade.DescriptionLiquids = desLiq;
                pgrade.DescriptionSolids = desSol;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

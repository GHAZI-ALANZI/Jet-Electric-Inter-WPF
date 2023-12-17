//Add view models

using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

namespace Jet_Electric_DataAccessLayer.DA
{

    class CertificationDA
    {
        JetDbContext db;

        public CertificationDA()
        {
            db = new JetDbContext();
        }

        public List<Certification> SelectAll()
        {
            return db.Certifications.ToList();
        }

        public bool InsertCertification(Certification cert)
        {
            db.Certifications.Add(cert);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var cert = db.Certifications.Where(x => x.ID == id).FirstOrDefault();
            if (cert != null)
            {
                db.Certifications.Remove(cert);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string name, string descrip)
        {
            var cert = db.Certifications.Where(x => x.ID == id).FirstOrDefault();
            if (cert != null)
            {
                cert.Name = name;
                cert.Description = descrip;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

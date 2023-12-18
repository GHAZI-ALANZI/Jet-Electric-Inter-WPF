// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class CertificationFactory
    {
        CertificationDA certDa;

        public CertificationFactory()
        {
            certDa = new CertificationDA();
        }

        public List<Certification> SelectAll()
        {
            return certDa.SelectAll();
        }

        public bool InsertCertification(Certification cert)
        {
            return certDa.InsertCertification(cert);
        }
    }
}

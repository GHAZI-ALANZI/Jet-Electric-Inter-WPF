// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class ContactFactory
    {
        ContactDA conDa;

        public ContactFactory()
        {
            conDa = new ContactDA();
        }

        public List<Contact> SelectAll()
        {
            return conDa.SelectAll();
        }

        public bool InsertContact(Contact con)
        {
            return conDa.InsertContact(con);
        }

        public bool Update(int id, string name, string phone, string email, string address)
        {
            return conDa.Update(id, name, phone, email, address);
        }
    }
}

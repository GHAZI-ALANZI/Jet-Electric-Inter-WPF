using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class ContactDA
    {
        JetDbContext db;

        public ContactDA()
        {
            db = new JetDbContext();
        }

        public List<Contact> SelectAll()
        {
            return db.Contacts.ToList();
        }

        public bool InsertContact(Contact con)
        {
            db.Contacts.Add(con);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var con = db.Contacts.Where(x => x.ID == id).FirstOrDefault();
            if (con != null)
            {
                db.Contacts.Remove(con);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string name, string phone, string email, string address)
        {
            var con = db.Contacts.Where(x => x.ID == id).FirstOrDefault();
            if (con != null)
            {
                con.CompanyName = name;
                con.Phone = phone;
                con.Email = email;
                con.Address = address;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

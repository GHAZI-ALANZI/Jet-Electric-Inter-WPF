using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_DataAccessLayer.Models;

//Add view models

namespace Jet_Electric_DataAccessLayer.DA
{
    class ProjectDA
    {
        JetDbContext db;

        public ProjectDA()
        {
            db = new JetDbContext();
        }

        public List<Project> SelectAll()
        {
            return db.Projects.ToList();
        }

        public bool InsertProject(Project proj)
        {
            db.Projects.Add(proj);
            return db.SaveChanges() > 0 ? true : false;
        }

        //CHECK IT
        public bool Delete(int id)
        {
            var proj = db.Projects.Where(x => x.ID == id).FirstOrDefault();
            if (proj != null)
            {
                db.Projects.Remove(proj);
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Update(int id, string name, int statusID, DateTime de)
        {
            var proj = db.Projects.Where(x => x.ID == id).FirstOrDefault();
            if (proj != null)
            {
                proj.Name = name;
                proj.CustomerOrder.OrderStatusID = statusID;
                proj.DeliveyDate = de;
                //proj.CustomerOrderID = OrderID;
            }
            return db.SaveChanges() > 0 ? true : false;
        }


    }
}

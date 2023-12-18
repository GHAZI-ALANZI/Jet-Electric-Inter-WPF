// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class ProjectFactory
    {
        ProjectDA projDa;

        public ProjectFactory()
        {
            projDa = new ProjectDA();
        }

        public List<Project> SelectAll()
        {
            return projDa.SelectAll();
        }

        public bool InsertProject(Project proj)
        {
            return projDa.InsertProject(proj);
        }

        public bool Update(int id, string name, int statusID, DateTime de)
        {
            return projDa.Update(id, name, statusID, de);
        }
    }
}

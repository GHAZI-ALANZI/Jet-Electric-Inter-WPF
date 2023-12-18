// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class TypeFactory
    {
        TypeDA typeDa;

        public TypeFactory()
        {
            typeDa = new TypeDA();
        }

        public List<Models.Type> SelectAll()
        {
            return typeDa.SelectAll();
        }

        public bool InsertType(Models.Type type)
        {
            return typeDa.InsertType(type);
        }
    }
}

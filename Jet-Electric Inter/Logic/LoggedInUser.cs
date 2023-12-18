

using Jet_Electric_DataAccessLayer.Models;

namespace Jet_Electric_Inter.Logic
{
    public class LoggedInUser
    {
        public Login Info;
        public void RemoveData()
        {
            Info = null;
        }
        private static LoggedInUser instance;

        private LoggedInUser() { }

        public static LoggedInUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoggedInUser();
                }
                return instance;
            }
        }


    }
}

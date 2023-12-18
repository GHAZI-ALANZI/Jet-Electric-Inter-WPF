using System.ComponentModel;

namespace ViewModels
{
    public class LoginViewModel : IDataErrorInfo
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Error
        {
            get
            {
                return null;
            }
        }
        public string this[string columnName]
        {
            get
            {
                string result = null;



                return result;
            }
        }

    }
}

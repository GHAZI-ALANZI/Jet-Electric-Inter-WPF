using System.ComponentModel;

namespace ViewModels
{
    public class ContactViewModel : IDataErrorInfo
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

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

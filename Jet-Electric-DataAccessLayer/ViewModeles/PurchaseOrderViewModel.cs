using System.ComponentModel;

namespace ViewModels
{
    public class PurchaseOrderViewModel : IDataErrorInfo
    {
        public int ID { get; set; }
        public System.DateTime PODate { get; set; }
        public int ContactID { get; set; }
        public int Quantity { get; set; }

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

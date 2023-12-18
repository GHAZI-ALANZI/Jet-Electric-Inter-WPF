using System.ComponentModel;


namespace ViewModels
{
    public class CustomerOrderViewModel : IDataErrorInfo
    {
        public int ID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public int ContactID { get; set; }

        public int ProdID { get; set; }
        public int Quantity { get; set; }

        public int AssignedEmployeeID { get; set; }
        public int OrderStatusID { get; set; }

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

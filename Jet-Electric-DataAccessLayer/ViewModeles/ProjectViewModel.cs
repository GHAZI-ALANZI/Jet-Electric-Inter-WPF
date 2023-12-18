using System.ComponentModel;

namespace ViewModels
{
    public class ProjectViewModel : IDataErrorInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DeliveryDate { get; set; }

        //Proj Item
        public int ProdID { get; set; } //Panel
        public int Quantity { get; set; }

        //Order Details
        public int CustomerOrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int ContactID { get; set; }
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

// Add DA namespace
using Jet_Electric_DataAccessLayer.DA;
using Jet_Electric_DataAccessLayer.Models;


namespace Jet_Electric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class CustomerOrderFactory
    {
        CustomerOrderDA coDa;

        public CustomerOrderFactory()
        {
            coDa = new CustomerOrderDA();
        }

        public List<CustomerOrder> SelectAll()
        {
            return coDa.SelectAll();
        }

        public bool InsertCustomerOrder(CustomerOrder po)
        {
            return coDa.InsertCustomerOrder(po);
        }
    }
}

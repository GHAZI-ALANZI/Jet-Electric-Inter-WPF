namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Inventory
    {
        public int ID { get; set; }
        public int StockLevel { get; set; }
        public int LocationID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
    }
}

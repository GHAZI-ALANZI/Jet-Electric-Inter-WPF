namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Make
    {

        public Make()
        {
            this.Products = new HashSet<Product>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

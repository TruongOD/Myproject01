namespace Myproject01.Entities
{
    public class WareHouse : Base
    {
        public int BrandID { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}

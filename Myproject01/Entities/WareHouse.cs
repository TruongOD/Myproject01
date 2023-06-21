namespace Myproject01.Entities
{
    public class WareHouse : Base
    {
        public string Name { get; set; }
        public int BrandID { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }

        public string Location { get; set; }
    }
}
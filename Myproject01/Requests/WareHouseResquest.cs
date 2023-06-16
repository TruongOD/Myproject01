namespace Myproject01.Requests
{
    public class WareHouseResquest
    {
        public int Id { get; set; }
        public int BrandID { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}

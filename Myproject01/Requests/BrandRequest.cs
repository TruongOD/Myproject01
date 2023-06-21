namespace Myproject01.Requests
{
    public class BrandRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public string Provider { get; set; }

        public double Price { get; set; }
    }
}

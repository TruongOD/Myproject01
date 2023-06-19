using Myproject01.Requests;

namespace Myproject01.Responses
{
    public class WarehouseResonses
    {
        public string Name { get; set; }

        public string Location { get; set; }

        //public int TotalProduct { get; set; }
        //public double TotalPrice { get; set; }
        public List<BrandRequest> BrandRequests { get; set; } = new List<BrandRequest>();
    }
}
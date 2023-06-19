using System.ComponentModel.DataAnnotations.Schema;

namespace Myproject01.Entities
{
    [Table("Brands")]
    public class Brand : Base
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}

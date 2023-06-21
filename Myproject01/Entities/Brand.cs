using System.ComponentModel.DataAnnotations.Schema;

namespace Myproject01.Entities
{
    [Table("Brands")]
    public class Brand : Base
    {
        public string Name { get; set; }
        public int ProductId { get; set; }

        public string Provider { get; set; }

        public double Price { get; set; }
    }
}
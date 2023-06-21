using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Myproject01.Entities
{
    [Table("Products")]
    public class Product : Base
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int BrandId { get; set; }

        // Nhà sản suất
        public string SeriesNumber { get; set; }
    }
}
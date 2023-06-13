using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Myproject01.Entities
{
    [Table("Products")]
    public class Product : Base
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Provider { get; set; }

        public int BrandId { get; set; }
        public string SeriesNumber { get; set; }
    }
}

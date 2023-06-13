using System.ComponentModel.DataAnnotations;

namespace Myproject01.Entities
{
    public class Base
    {
        [Key]
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Createdby { get; set; }
        public string Updatedby { get; set; }

    }
}

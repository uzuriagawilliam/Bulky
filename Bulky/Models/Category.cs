using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(40) ]
        public string Name { get; set; } = string.Empty;
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}

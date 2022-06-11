using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Test.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = String.Empty;
        [Required]
        [StringLength(60)]
        public string Author { get; set; } = String.Empty;
        [Required]
        [MaxLength(10)]
        public double Price { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}

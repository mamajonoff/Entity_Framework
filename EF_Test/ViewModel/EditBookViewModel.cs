using System.ComponentModel.DataAnnotations;

namespace EF_Test.ViewModel
{
    public class EditBookViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public double Price { get; set; }
    }
}

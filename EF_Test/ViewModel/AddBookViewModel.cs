using System.ComponentModel.DataAnnotations;

namespace EF_Test.ViewModel
{
    public class AddBookViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public double Price { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Портфолио.Models
{
    public class Review
    {
        [Key]

        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Rating { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Портфолио.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly Start { get; set; }
        public DateOnly End { get; set; }
    }
}
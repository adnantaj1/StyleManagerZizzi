using System.ComponentModel.DataAnnotations;

namespace StyleManagerUIZizzi.Models
{
    public class ColorDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string ColorNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string ColorName { get; set; } = string.Empty;
    }
}

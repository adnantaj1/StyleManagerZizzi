using System.ComponentModel.DataAnnotations;

namespace StyleManagerUIZizzi.Models
{
    public class SizeDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string SizeNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string SizeName { get; set; } = string.Empty;
    }
}

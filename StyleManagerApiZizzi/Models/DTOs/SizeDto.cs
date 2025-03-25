using System.ComponentModel.DataAnnotations;

namespace StyleManagerApiZizzi.Models
{
    public class SizeDto
    {
        [Required]
        [MaxLength(10)]
        public string SizeNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string SizeName { get; set; } = string.Empty;
    }
}

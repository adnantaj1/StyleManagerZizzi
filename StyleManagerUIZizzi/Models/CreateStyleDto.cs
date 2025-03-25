using System.ComponentModel.DataAnnotations;

namespace StyleManagerUIZizzi.Models
{
    public class CreateStyleDto
    {
        [Required]
        public string StyleNumber { get; set; } = string.Empty;

        [Required]
        public int ColorId { get; set; }

        [Required]
        public int SizeId { get; set; }
    }
}

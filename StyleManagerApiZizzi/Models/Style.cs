using System.ComponentModel.DataAnnotations;

namespace StyleManagerApiZizzi.Models
{
    public class Style
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "StyleNumber is required.")]
        [MaxLength(20)]
        public string StyleNumber { get; set; } = string.Empty;

        // Foreign Keys
        [Required]
        public int ColorId { get; set; }

        [Required]
        public int SizeId { get; set; }

        // Navigation Properties
        public Color? Color { get; set; }
        public Size? Size { get; set; }
    }
}

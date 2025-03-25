using System.ComponentModel.DataAnnotations;

namespace StyleManagerApiZizzi.Models
{
    public class Size
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "SizeNumber is required.")]
        [MaxLength(10)]
        public string SizeNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "SizeName is required.")]
        [MaxLength(20)]
        public string SizeName { get; set; } = string.Empty;   

        // Navigation property
        public ICollection<Style>? Styles { get; set; }
    }
}

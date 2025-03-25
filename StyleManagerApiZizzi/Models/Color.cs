using System.ComponentModel.DataAnnotations;

namespace StyleManagerApiZizzi.Models
{
    public class Color
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "ColorNumber is required.")]
        [MaxLength(10)]
        public string ColorNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "ColorName is required.")]
        [MaxLength(20)]
        public string ColorName { get; set; } = string.Empty;   

        // Navigation property
        public ICollection<Style>? Styles { get; set; }
    }
}

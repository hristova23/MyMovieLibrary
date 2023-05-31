using System.ComponentModel.DataAnnotations;

namespace MyMovieLibrary.Data.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;
    }
}

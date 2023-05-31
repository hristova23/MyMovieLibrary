using System.ComponentModel.DataAnnotations;

namespace MyMovieLibrary.Data.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Required]
        public Genre Genre { get; set; } = null!;

        [Required]
        public DateTime PremiereDate { get; set; }

        public ICollection<Actor> Actors { get; set; } = new HashSet<Actor>();
    }
}

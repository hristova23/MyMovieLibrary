using System.ComponentModel.DataAnnotations;

namespace MyMovieLibrary.Data.Models
{
    public class Genre
    {
        public Genre()
        {
            this.Movies = new HashSet<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        public ICollection<Movie> Movies { get; set; } = new HashSet<Movie>();
    }
}

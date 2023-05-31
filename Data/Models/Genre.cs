using System.ComponentModel.DataAnnotations;

namespace MyMovieLibrary.Data.Models
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set;} = Guid.NewGuid();

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        public ICollection<Movie> Movies { get; set; } = new HashSet<Movie>();
    }
}

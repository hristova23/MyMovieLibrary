using System.ComponentModel.DataAnnotations;

namespace MyMovieLibrary.Data.Models
{
    public class Actor
    {
        [Key]
        public Guid Id { get; set;} = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public ICollection<MovieActor> Movies { get; set; } = new HashSet<MovieActor>();
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovieLibrary.Data.Models
{
    public class MovieActor
    {
        [Required]
        public Guid MovieId { get; }

        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;

        [Required]
        public Guid ActorId { get; }

        [ForeignKey(nameof(ActorId))]
        public Actor Actor { get; set; } = null!;
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovieLibrary.Data.Models
{
    public class MovieActor
    {
        [Required]
        public int MovieId { get; set; }

        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;

        [Required]
        public string ActorId { get; set; } = null!;

        [ForeignKey(nameof(ActorId))]
        public Actor Actor { get; set; } = null!;
    }
}

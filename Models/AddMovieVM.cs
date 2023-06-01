using System.ComponentModel.DataAnnotations;

namespace MyMovieLibrary.Models
{
    public class AddMovieVM
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Premiere Date")]
        public DateTime PremiereDate { get; set; }

        public string GenreId { get; set; }
        
        public IEnumerable<GenreVM> Genres { get; set; } = new List<GenreVM>();

        [Display(Name = "Actors names")]
        public string ActorsNames { get; set; }

        public ICollection<ActorVM> Actors { get; set; } = new List<ActorVM>();
    }
}

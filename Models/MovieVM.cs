namespace MyMovieLibrary.Models
{
    public class MovieVM
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public DateTime PremiereDate { get; set; }

        public ICollection<ActorVM> Actors { get; set; }
    }
}

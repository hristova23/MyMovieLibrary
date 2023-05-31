using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMovieLibrary.Data.Models;

namespace MyMovieLibrary.Data.Seeders
{
    internal class MovieSeeder : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(SeedMovies());
        }

        private List<Movie> SeedMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
               new Movie()
               {
                   Id = Guid.Parse("7dca29e5-2322-4453-b303-768cf8d1e6bc"),
                   Title = "Predestination",
                   GenreId = Guid.Parse("d09e5f41-9592-4c4c-a9ac-1a75d413b7ed"),
                   PremiereDate = new DateTime(2015,01,09,0,0,0)
               },
               new Movie()
               {
                   Id = Guid.Parse("b38f029e-018f-40e7-830d-958e7a658fe0"),
                   Title = "Skyscraper",
                   GenreId = Guid.Parse("6d7b3135-dd01-4dc1-8cb2-c0631f66bdf0"),
                   PremiereDate = new DateTime(2018,07,13,0,0,0)
               },
               new Movie()
               {
                   Id = Guid.Parse("6c105a1c-011b-4605-bc7e-6e12eb470338"),
                   Title = "Steve Jobs",
                   GenreId = Guid.Parse("c8324202-a9bf-4d8e-a0ce-c21a046c8a52"),
                   PremiereDate = new DateTime(2015,12,04,0,0,0)
               },
               new Movie()
               {
                   Id = Guid.Parse("f1a9a5d1-aa68-4cba-979a-817cc502ca99"),
                   Title = "The Purge",
                   GenreId = Guid.Parse("02ec846d-5f9c-4b31-b17f-413f0b49493b"),
                   PremiereDate = new DateTime(2013,05,31,0,0,0)
               },
               new Movie()
               {
                   Id = Guid.Parse("1a4d6444-4739-4058-a905-ba58f9c43779"),
                   Title = "Black Adam",
                   GenreId = Guid.Parse("cd501ea6-cf55-4382-807e-4037599647b3"),
                   PremiereDate = new DateTime(2022,10,21,0,0,0)
               },
               new Movie()
               {
                   Id = Guid.Parse("e1e820f4-a38d-41c3-b87f-accc0eaa5672"),
                   Title = "Baywatch",
                   GenreId = Guid.Parse("3104db1a-525c-4f63-aedf-242184ee6637"),
                   PremiereDate = new DateTime(2017,06,02,0,0,0)
               },
            };

            return movies;
        }
    }
}

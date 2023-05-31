using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMovieLibrary.Data.Models;

namespace MyMovieLibrary.Data.Seeders
{
    internal class GenreSeeder : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(SeedGenres());
        }

        private List<Genre> SeedGenres()
        {
            List<Genre> genres = new List<Genre>()
            {
               new Genre()
               {
                   Id = Guid.Parse("6d7b3135-dd01-4dc1-8cb2-c0631f66bdf0"),
                   Name = "Action"
               },
               new Genre()
               {
                   Id = Guid.Parse("9e315f6b-b49c-4596-9154-f9011715b25b"),
                   Name = "Thriller"
               },
               new Genre()
               {
                   Id = Guid.Parse("02ec846d-5f9c-4b31-b17f-413f0b49493b"),
                   Name = "Horror"
               },
               new Genre()
               {
                   Id = Guid.Parse("c8324202-a9bf-4d8e-a0ce-c21a046c8a52"),
                   Name = "Drama"
               },
               new Genre()
               {
                   Id = Guid.Parse("3104db1a-525c-4f63-aedf-242184ee6637"),
                   Name = "Comedy"
               },
               new Genre()
               {
                   Id = Guid.Parse("d4da5470-0224-4efc-9fe2-5cc2747630f2"),
                   Name = "Romance"
               },
               new Genre()
               {
                   Id = Guid.Parse("b451328c-8f3c-4511-94c2-29f2e3402eb6"),
                   Name = "Fantasy"
               },
               new Genre()
               {
                   Id = Guid.Parse("d09e5f41-9592-4c4c-a9ac-1a75d413b7ed"),
                   Name = "Science Fiction"
               },
               new Genre()
               {
                   Id = Guid.Parse("cd501ea6-cf55-4382-807e-4037599647b3"),
                   Name = "Adventure"
               },
               new Genre()
               {
                   Id = Guid.Parse("278b2b4e-e0d7-45cb-93ed-6d38489922a7"),
                   Name = "Crime"
               },
               new Genre()
               {
                   Id = Guid.Parse("e789f0b0-219e-4632-9d0e-d41233ed72f5"),
                   Name = "Biographical"
               },
            };

            return genres;
        }
    }
}

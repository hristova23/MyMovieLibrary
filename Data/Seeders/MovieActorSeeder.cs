using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMovieLibrary.Data.Models;

namespace MyMovieLibrary.Data.Seeders
{
    public class MovieActorSeeder : IEntityTypeConfiguration<MovieActor>
    {
        public void Configure(EntityTypeBuilder<MovieActor> builder)
        {
            builder.HasData(SeedMovieActors());
        }

        private List<MovieActor> SeedMovieActors()
        {
            List<MovieActor> movieActorList = new List<MovieActor>()
            {
               new MovieActor()
               {
                   MovieId = Guid.Parse("7dca29e5-2322-4453-b303-768cf8d1e6bc"),
                   ActorId = Guid.Parse("21371c7e-3ab9-4dcc-8f53-51c8eef910ed")
               },
               new MovieActor()
               {
                   MovieId = Guid.Parse("7dca29e5-2322-4453-b303-768cf8d1e6bc"),
                   ActorId = Guid.Parse("ba3af6d3-cf1e-4348-a832-cbbf083c8cfc")
               },
               new MovieActor()
               {
                   MovieId = Guid.Parse("7dca29e5-2322-4453-b303-768cf8d1e6bc"),
                   ActorId = Guid.Parse("a783e8fc-55c1-4ec3-ae4f-6ddec38e6d8d")
               },
               new MovieActor()
               {
                   MovieId = Guid.Parse("b38f029e-018f-40e7-830d-958e7a658fe0"),
                   ActorId = Guid.Parse("a783e8fc-55c1-4ec3-ae4f-6ddec38e6d8d")
               },
               new MovieActor()
               {
                   MovieId = Guid.Parse("b38f029e-018f-40e7-830d-958e7a658fe0"),
                   ActorId = Guid.Parse("409512bc-bf31-4a6e-ba0d-13a052a51109")
               },
               new MovieActor()
               {
                   MovieId = Guid.Parse("6c105a1c-011b-4605-bc7e-6e12eb470338"),
                   ActorId = Guid.Parse("ba3af6d3-cf1e-4348-a832-cbbf083c8cfc")
               },
               new MovieActor()
               {
                   MovieId = Guid.Parse("6c105a1c-011b-4605-bc7e-6e12eb470338"),
                   ActorId = Guid.Parse("79d8a005-9662-4c48-8e1a-89c3e163c6dd")
               },
               new MovieActor()
               {
                   MovieId = Guid.Parse("f1a9a5d1-aa68-4cba-979a-817cc502ca99"),
                   ActorId = Guid.Parse("21371c7e-3ab9-4dcc-8f53-51c8eef910ed")
               },
               new MovieActor()
               {
                   MovieId = Guid.Parse("1a4d6444-4739-4058-a905-ba58f9c43779"),
                   ActorId = Guid.Parse("409512bc-bf31-4a6e-ba0d-13a052a51109")
               },
               new MovieActor()
               {
                   MovieId = Guid.Parse("1a4d6444-4739-4058-a905-ba58f9c43779"),
                   ActorId = Guid.Parse("ee4498a8-2251-402e-8ce0-070807f960c9")
               },
               new MovieActor()
               {
                   MovieId = Guid.Parse("9ed08e60-a2c6-425a-bf5d-0a1bd92ee83b"),
                   ActorId = Guid.Parse("873dac8f-627c-44f3-a1d3-982817ca65c6")
               },
            };

            return movieActorList;
        }
    }
}

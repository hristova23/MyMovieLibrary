using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMovieLibrary.Data.Models;

namespace MyMovieLibrary.Data.Seeders
{
    internal class ActorSeeder : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(SeedActors());
        }

        private List<Actor> SeedActors()
        {
            List<Actor> actors = new List<Actor>()
            {
               new Actor()
               {
                   Id = Guid.Parse("21371c7e-3ab9-4dcc-8f53-51c8eef910ed"),
                   Name = "Ethan Hawke"
               },
               new Actor()
               {
                   Id = Guid.Parse("ba3af6d3-cf1e-4348-a832-cbbf083c8cfc"),
                   Name = "Sarah Snook"
               },
               new Actor()
               {
                   Id = Guid.Parse("a783e8fc-55c1-4ec3-ae4f-6ddec38e6d8d"),
                   Name = "Noah Taylor"
               },
               new Actor()
               {
                   Id = Guid.Parse("409512bc-bf31-4a6e-ba0d-13a052a51109"),
                   Name = "Dwayne Johnson"
               },
               new Actor()
               {
                   Id = Guid.Parse("79d8a005-9662-4c48-8e1a-89c3e163c6dd"),
                   Name = "Michael Fassbender"
               },
               new Actor()
               {
                   Id = Guid.Parse("ee4498a8-2251-402e-8ce0-070807f960c9"),
                   Name = "Sarah Shahi"
               },
               new Actor()
               {
                   Id = Guid.Parse("873dac8f-627c-44f3-a1d3-982817ca65c6"),
                   Name = "Keanu Reeves"
               },
            };

            return actors;
        }
    }
}

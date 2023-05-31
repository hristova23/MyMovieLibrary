using MyMovieLibrary.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MyMovieLibrary.Data
{
    public class MyMovieLibraryDbContext : DbContext
    {
        public MyMovieLibraryDbContext(DbContextOptions<MyMovieLibraryDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Movie>(movie =>
            {
                movie
                    .HasOne(m => m.Genre)
                    .WithMany(g => g.Movies)
                    .HasForeignKey(m => m.GenreId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<MovieActor>(movieActorEntity =>
            {
                movieActorEntity
                    .HasKey(ma => new { ma.MovieId, ma.ActorId});

                movieActorEntity
                    .HasOne(ma => ma.Movie)
                    .WithMany(ma => ma.Actors)
                    .HasForeignKey(ma => ma.MovieId)
                    .OnDelete(DeleteBehavior.Restrict);

                movieActorEntity
                    .HasOne(ma => ma.Actor)
                    .WithMany(ma => ma.Movies)
                    .HasForeignKey(ma => ma.ActorId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            base.OnModelCreating(builder);
        }

        public DbSet<Movie> Movies { get; set; } = null!;

        public DbSet<Genre> Genres { get; set; } = null!;

        public DbSet<Actor> Actors { get; set; } = null!;
    }
}
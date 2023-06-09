﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovieLibrary.Data.Models
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Required]
        public Guid GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!; // <-- mapping property

        [Required]
        public DateTime PremiereDate { get; set; }

        public ICollection<MovieActor> Actors { get; set; } = new HashSet<MovieActor>();
    }
}

namespace FilmLibrary.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static FilmLibrary.Data.Common.DataConstants;
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MOVIE_TITLE_MAX_LENGHT)]
        public string Title { get; set; }

        [Required]
        [MaxLength(DESCRIPTION_MAX_LENGHT)]
        public string Description { get; set; }

        [Required]
        [ForeignKey(nameof(Director))]
        public int DirectorId { get; set; }

        public Director Director { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        [MaxLength(PRODUCTION_MAX_LENGHT)]
        public string Production { get; set; }

        [Required]
        [MaxLength(ORIGINAL_LANGUAGE_MAX_LENGHT)]
        public string OriginalLanguage { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }

        [Required]
        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        [Required]
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}

namespace FilmLibrary.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static FilmLibrary.Data.Common.DataConstants;

    public class Genre
    {
        public Genre()
        {
            this.Movies = new HashSet<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GENRE_NAME_MAX_LENGHT)]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}

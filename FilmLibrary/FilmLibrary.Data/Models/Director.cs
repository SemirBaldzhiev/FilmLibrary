namespace FilmLibrary.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static FilmLibrary.Data.Common.DataConstants;

    public class Director
    {
        public Director()
        {
            this.Movies = new HashSet<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DIRECTOR_NAME_MAX_LENGHT)]
        public string DirectorName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}

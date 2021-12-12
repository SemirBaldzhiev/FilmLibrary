namespace FilmLibrary.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static FilmLibrary.Data.Common.DataConstants;

    public class Country
    {
        public Country()
        {
            this.Movies = new HashSet<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(COUNTRY_NAME_MAX_LENGHT)]
        public string CountryName { get; set; }
        
        [Required]
        [MaxLength(COUNTRY_CODE_MAX_LENGHT)]
        public string CountryCode { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}

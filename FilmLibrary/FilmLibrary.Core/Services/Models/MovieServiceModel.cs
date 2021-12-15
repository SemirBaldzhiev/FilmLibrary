using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Core.Services.Models
{
    public class MovieServiceModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int DrectorId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string Production { get; set; }

        public string OriginalLanguage { get; set; }

        public string ImageUrl { get; set; }

        public int GenreId { get; set; }

        public int CountryId { get; set; }
    }
}

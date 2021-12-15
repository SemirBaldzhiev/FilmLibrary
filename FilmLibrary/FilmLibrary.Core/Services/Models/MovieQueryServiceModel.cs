using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Core.Services.Models
{
    public class MovieQueryServiceModel
    {
        public int CurrentPage { get; init; }

        public int MoviesPerPage { get; init; }

        public int TotalMovies { get; init; }

        public IEnumerable<MovieServiceModel> Movies { get; init; }
    }
}

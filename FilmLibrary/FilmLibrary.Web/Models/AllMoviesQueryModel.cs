namespace FilmLibrary.Web.Models
{
    using FilmLibrary.Core.Services.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AllMoviesQueryModel
    {
        public const int MoviesPerPage = 3;

        public string Title { get; init; }

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalMovies { get; set; }

        public IEnumerable<MovieServiceModel> Movies { get; set; }
    }
}

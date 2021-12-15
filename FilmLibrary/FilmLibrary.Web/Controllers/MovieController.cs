namespace FilmLibrary.Web.Controllers
{
    using FilmLibrary.Core.Services.Movies;
    using FilmLibrary.Web.Models;
    using Microsoft.AspNetCore.Mvc;

    public class MovieController : Controller
    {
        private readonly IMovieService movies;

        public MovieController(IMovieService movies)
        {
            this.movies = movies;
        }
        public IActionResult Index(AllMoviesQueryModel query)
        {
            var queryResult = this.movies.All(
                query.Title,
                query.SearchTerm,
                query.CurrentPage,
                AllMoviesQueryModel.MoviesPerPage);

            query.TotalMovies = queryResult.TotalMovies;
            query.Movies = queryResult.Movies;

            return View(query);
        }


    }
}

using FilmLibrary.Core.Services.Models;
using FilmLibrary.Data.Models;
namespace FilmLibrary.Core.Services.Movies
{
    using FilmLibrary.Web.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MovieService : IMovieService
    {

        private readonly FilmLibraryDbContext context;

        public MovieQueryServiceModel All(string title = null, string searchTerm = null, int currentPage = 1, int carsPerPage = int.MaxValue)
        {
            var carsQuery = this.context.Movies.AsQueryable();

            if (!string.IsNullOrWhiteSpace(title))
            {
                carsQuery = carsQuery.Where(c => c.Title == title);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                carsQuery = carsQuery.Where(c =>
                    c.Description.ToLower().Contains(searchTerm.ToLower()));
            }

            var totalCars = carsQuery.Count();

            var movies = GetCars(carsQuery
                .Skip((currentPage - 1) * carsPerPage)
                .Take(carsPerPage));

            return new MovieQueryServiceModel
            {
                TotalMovies = totalCars,
                CurrentPage = currentPage,
                MoviesPerPage = carsPerPage,
                Movies = movies
            };
        }

        public int Create(string title, string description, int directorId, DateTime releaseDate, TimeSpan duration, string production, string originalLanguage, string imageUrl, int genreId, int countryId)
        {
            var movieData = new Movie
            {
                Title = title,
                Description = description,
                DirectorId = directorId,
                ReleaseDate = releaseDate,
                Production = production,
                OriginalLanguage = originalLanguage,
                ImageUrl = imageUrl,
                GenreId = genreId,
                CountryId = countryId
            };

            this.context.Movies.Add(movieData);
            this.context.SaveChanges();

            return movieData.Id;
        }

        public bool Edit(int id, string title, string description, int directorId, DateTime releaseDate, TimeSpan duration, string production, string originalLanguage, string imageUrl, int genreId, int countryId)
        {
            var movie = this.context.Movies.Find(id);

            if (movie == null)
            {
                return false;
            }

            movie.Title = title;
            movie.Description = description;
            movie.DirectorId = directorId;
            movie.ReleaseDate = releaseDate;
            movie.Production = production;
            movie.OriginalLanguage = originalLanguage;
            movie.ImageUrl = imageUrl;
            movie.GenreId = genreId;
            movie.CountryId = countryId;

            this.context.SaveChanges();

            return true;
        }

        private IEnumerable<MovieServiceModel> GetCars(IQueryable<Movie> carQuery)
            => carQuery
                .Select(car => new MovieServiceModel
                {
                    Id = car.Id,   
                    Title = car.Title,
                    Description = car.Description,
                    DrectorId = car.DirectorId,
                    ReleaseDate = car.ReleaseDate, 
                    Production = car.Production,
                    OriginalLanguage = car.OriginalLanguage,
                    ImageUrl = car.ImageUrl,
                    GenreId = car.GenreId,
                    CountryId = car.CountryId,
                })
                .ToList();
    }
}

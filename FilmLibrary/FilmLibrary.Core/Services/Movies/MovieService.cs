using FilmLibrary.Data.Models;
using FilmLibrary.Web.Data;
using System;

namespace FilmLibrary.Core.Services.Movies
{
    public class MovieService : IMovieService
    {

        private readonly FilmLibraryDbContext context;
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
    }
}

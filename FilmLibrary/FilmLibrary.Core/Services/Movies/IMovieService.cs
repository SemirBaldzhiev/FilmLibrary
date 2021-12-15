namespace FilmLibrary.Core.Services.Movies
{
    using FilmLibrary.Core.Services.Models;
    using System;
    using System.Collections.Generic;

    public interface IMovieService
    {
        MovieQueryServiceModel All(string title = null,
            string searchTerm = null,
            int currentPage = 1,
            int carsPerPage = int.MaxValue);

        int Create(string title,
            string description,
            int directorId,
            DateTime releaseDate,
            TimeSpan duration,
            string production,
            string originalLanguage,
            string imageUrl,
            int genreId,
            int countryId);

        bool Edit(int id,
            string title,
            string description,
            int directorId,
            DateTime releaseDate,
            TimeSpan duration,
            string production,
            string originalLanguage,
            string imageUrl,
            int genreId,
            int countryId);


    }
}

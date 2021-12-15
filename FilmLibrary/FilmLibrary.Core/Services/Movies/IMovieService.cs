namespace FilmLibrary.Core.Services.Movies
{
    using System;

    public interface IMovieService
    {
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

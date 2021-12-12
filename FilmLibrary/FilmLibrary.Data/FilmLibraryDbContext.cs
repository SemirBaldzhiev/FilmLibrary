namespace FilmLibrary.Web.Data
{
    using FilmLibrary.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class FilmLibraryDbContext : IdentityDbContext
    {
        public FilmLibraryDbContext(DbContextOptions<FilmLibraryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}

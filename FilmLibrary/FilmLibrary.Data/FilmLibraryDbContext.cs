namespace FilmLibrary.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class FilmLibraryDbContext : IdentityDbContext
    {
        public FilmLibraryDbContext(DbContextOptions<FilmLibraryDbContext> options)
            : base(options)
        {
        }
    }
}

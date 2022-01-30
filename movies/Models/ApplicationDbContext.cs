using Microsoft.EntityFrameworkCore;

namespace movies.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<genre> Genres { get; set;}
        public DbSet<Movie> Movies { get; set;}
    }
}

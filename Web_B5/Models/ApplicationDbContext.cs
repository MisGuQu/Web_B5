namespace Web_B5.Models
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Category> categories { get; set; }
        public DbSet<Book> books { get; set; }
    }
}

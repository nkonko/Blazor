namespace BlazorApp.Server
{
    using BlazorApp.Shared.Models;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

        public DbSet<Product> Productos { get; set; }
    }
}

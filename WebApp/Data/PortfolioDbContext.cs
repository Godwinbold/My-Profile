using Microsoft.EntityFrameworkCore;
using WebApp.Models.Domain;

namespace WebApp.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Project> Projects { get; set; }
    }
}

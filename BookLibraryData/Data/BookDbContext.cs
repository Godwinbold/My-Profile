using BookLibraryData.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryData.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
		public DbSet<Genre> Genres{ get; set; }
		public DbSet<Category> Categories { get; set; }

	}
}

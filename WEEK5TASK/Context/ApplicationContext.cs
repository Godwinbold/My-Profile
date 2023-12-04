using Microsoft.EntityFrameworkCore;
using BookLibraryData.Models;

namespace BookLibraryData.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public Dbset<Book> Books { get; set; }

    }
}

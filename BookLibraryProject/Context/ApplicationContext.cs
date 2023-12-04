using BookLibraryProject.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BookLibraryProject.Context
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions option) : base(option) { }
       public DbSet<Book> Book { get; set; }
    }
}

using Books.Models;
using Microsoft.EntityFrameworkCore;
namespace Books
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public DbSet<BookModel> Books { get; set; }
    }
}

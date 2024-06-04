using ASP.NET_BOOKMANAGER_.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_BOOKMANAGER_.Database
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Study> Studies { get; set; }
    }
}

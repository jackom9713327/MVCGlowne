using Microsoft.EntityFrameworkCore;
using BibliotekaCyfrowa.Models;

namespace BibliotekaCyfrowa.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
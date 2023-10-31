using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _1670Project.Models;

namespace _1670Project.Models
{
    public class BookStoreContext : IdentityDbContext<User>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }
        public DbSet<_1670Project.Models.Genre> Genre { get; set; } = default!;
        public DbSet<_1670Project.Models.Book> Book { get; set; } = default!;
    }
}

using BooksNET6API.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksNET6API.DBContext
{
    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {

        }
    }
}

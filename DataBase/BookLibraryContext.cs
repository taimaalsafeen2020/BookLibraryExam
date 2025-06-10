using Microsoft.EntityFrameworkCore;
using BookLibraryExam.Models;

namespace BookLibraryExam.Data
{
    public class BookLibraryContext : DbContext
    {
        public BookLibraryContext(DbContextOptions<BookLibraryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}

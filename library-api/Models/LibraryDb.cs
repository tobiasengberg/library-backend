using Microsoft.EntityFrameworkCore;

namespace library_api.Models;

public class LibraryDb : DbContext
{
    public LibraryDb(DbContextOptions<LibraryDb> options) : base(options)
    {
        
    }

    public DbSet<Book> Books { get; set; }
}
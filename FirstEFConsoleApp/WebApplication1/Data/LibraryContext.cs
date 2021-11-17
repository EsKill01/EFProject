using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors;

        public DbSet<Book> Books;

        public LibraryContext(DbContextOptions<LibraryContext> options) : base (options)
        {

        }
    }
}

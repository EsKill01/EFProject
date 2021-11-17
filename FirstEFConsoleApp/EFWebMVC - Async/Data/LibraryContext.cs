using EFWebMVC_Async.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebMVC
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<AuditEntity> AuditEntities { get; set; }

        public DbSet<BookFile> BookFiles { get; set; }

        public DbSet<PhsicalLibrary> PhisicalLibraries { get; set; }

        public DbSet<PhsicalBook> PhisicalBooks { get; set; }

        public DbSet<Publisher> Publishers { get; set; }


        public IQueryable<ProliphAuthor> GetProliphAuthors(int rows) => FromExpression(() => GetProliphAuthors(rows));


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var author = modelBuilder.Entity<Author>();

            author.HasData(new[]
            {
                new Author {AuthorId = 1, Name = "Stephen", LastName = "King"},
                new Author {AuthorId = 2, Name = "Isac", LastName = "Asimov"}
            });

            var publisher = modelBuilder.Entity<Publisher>();

            publisher.HasData(new[]
            {
                new Publisher {PublisherId = 1, Name = "Entre letras"}
            });

            var book = modelBuilder.Entity<Book>();

            book.HasData(new[]{
                new Book {BookId = new Random().Next(), AuthorID = 1, Tittle = "Los ojos del dragon", Sinopsis = "El libro de los ojos del dragon", PublisherId = 1},
                new Book {BookId = new Random().Next(), AuthorID = 1, Tittle = "La torre oscura 1", Sinopsis = "El libro de los ojos del dragon", PublisherId = 1},
                new Book {BookId = new Random().Next(), AuthorID = 1, Tittle = "Yo Robot", Sinopsis = "El libro de los ojos del dragon", PublisherId = 1}
                });

            var bookRating = modelBuilder.Entity<RatedBook>();

            bookRating

            

            bookRating.HasData(new[]{
                 new RatedBook {BookId = 1, RatedBookId = 1, Name = "Juanjo", Stars = 5},
                 new RatedBook {BookId = 2, RatedBookId = 1, Name = "Juanjo", Stars = 5},
                 new RatedBook {BookId = 3, RatedBookId = 1, Name = "Juanjo", Stars = 5},
                 new RatedBook {BookId = 4, RatedBookId = 1, Name = "Juanjo", Stars = 5},
                 new RatedBook {BookId = 5, RatedBookId = 1, Name = "Juanjo", Stars = 5},
                 new RatedBook {BookId = 6, RatedBookId = 1, Name = "Juanjo", Stars = 5},
                 new RatedBook {BookId = 7, RatedBookId = 1, Name = "Juanjo", Stars = 5},
                });


            modelBuilder.Entity<RatedBook>()
                .ToView("MostHighlyRatedBooks", schema: "dbo")
                .HasNoKey();

            modelBuilder.HasDbFunction(typeof(LibraryContext).GetMethod(nameof(GetProliphAuthors), new[] { typeof(int) }))
                .HasName("MostProlificAuthors")
                .HasSchema("dbo");

            modelBuilder.Entity<Country>().ToTable("Countries");
            base.OnModelCreating(modelBuilder);
        }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }
    }
}

using FirtsEFCoreConsoleApp.Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FirtsEFCoreConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new LibraryContext();

            //context.Database.EnsureCreated();

            var author = new Author()
            {
                Name = "Stephen",
                LastName = "King"
            };

            var book = new Book()
            {
                Tittle = "Los ojos del dragón",
                Sinopsis = "Prueba de un libro",
                Author = author
            };

            context.Authors.Add(author);
            context.Books.Add(book);

            await context.SaveChangesAsync();

            var bookFRomDB = context.Books.FirstOrDefault(b => b.Tittle == "Los ojos del dragón");
        }
    }
}

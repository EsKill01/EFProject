using EFCoreReverseEngineering.Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreReverseEngineering
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new LibraryContext();

            var author = new Author()
            {
                Name = "Esteban",
                LastName = "Barboza"
            };

            var book = new Book()
            {
                Author = author,
                Tittle = "Los ojos del dragon 2",
                Sinopsis = "Prueba"
            };

            context.Authors.Add(author);
            context.Books.Add(book);

            await context.SaveChangesAsync();

            var bookFromDB = context.Books.FirstOrDefault(b => b.Tittle == "Los ojos del dragon 2");

            if (bookFromDB != null)
            {
                context.Books.Remove(bookFromDB);
            }

            var authorFromDB = context.Authors.FirstOrDefault(a => a.Name == "Esteban");

            if (authorFromDB != null)
            {
                context.Authors.Remove(authorFromDB);
            }

            await context.SaveChangesAsync();

        }
    }
}

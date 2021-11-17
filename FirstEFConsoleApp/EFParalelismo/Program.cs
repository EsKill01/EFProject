using EFWebMVC;
using FirtsEFCoreConsoleApp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFParalelismo
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {

            var authors = new[]
            {
                new Author
                {
                    Name = "Robert",
                    LastName = "Ceci Martin"
                },
                new Author
                {
                    Name = "Martin",
                    LastName = "Flowler"
                },
            };

            var tasks = new List<Task>();

            foreach (var item in authors)
            {
                tasks.Add(Task.Run(async () =>
                {

                    using LibraryContext context = new LibraryContext();
                    await context.AddAsync(item);
                    await context.SaveChangesAsync();
                    context.Authors.Remove(item);
                    await context.SaveChangesAsync();
                }));
            }

            await Task.WhenAll(tasks);

            return await Task.FromResult(1);
        }
    }
}

using FirtsEFCoreConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EFContextoTiempoDiseño
{
    class Program
    {
        private static LibraryContext _context;
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<LibraryContext>(options =>
                {
                    options.UseSqlServer("Data Source = MJ0EK0Y4; Initial Catalog = FirtsEFCoreConsoleApp; Integrated Security = True");
                }, ServiceLifetime.Transient, ServiceLifetime.Transient).BuildServiceProvider();

            _context = serviceProvider.GetRequiredService<LibraryContext>();
        }
    }
}

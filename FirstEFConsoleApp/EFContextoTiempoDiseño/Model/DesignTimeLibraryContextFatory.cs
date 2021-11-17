using FirtsEFCoreConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContextoTiempoDiseño.Model
{
    public class DesignTimeLibraryContextFatory : IDesignTimeDbContextFactory<LibraryContext>
    {
        public LibraryContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<LibraryContext>();

            options.UseSqlServer("Data Source = MJ0EK0Y4; Initial Catalog = FirtsEFCoreConsoleApp; Integrated Security = True");

            return new LibraryContext(options.Options);
        }
    }
}

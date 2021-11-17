using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Book
    {
        public int BookId { get; set; }

        public int AuthorID { get; set; }

        public Author Author { get; set; }

        public string Tittle { get; set; }

        public string Sinopsis { get; set; }
    }
}

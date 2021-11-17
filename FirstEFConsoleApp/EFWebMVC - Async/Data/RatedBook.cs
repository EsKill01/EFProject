using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebMVC_Async.Data
{
    public class RatedBook
    {
        public int RatedBookId { get; set; }

        public int BookId { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public decimal Stars { get; set; }
    }
}

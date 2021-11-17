using EFWebMVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebMVC_Async.Data
{
    public class BookFile
    {
        public int BookFileId { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }

        public string InternalPath { get; set; }

        public BookFormat BookFormat { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebMVC_Async.Data
{
    public class ProliphAuthor
    {

        public int ProliphAuthorId { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public int BookCount { get; set; }
    }
}

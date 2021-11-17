using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreReverseEngineering.Model
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

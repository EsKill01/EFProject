using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebMVC_Async.Data
{
    [Table("BooksFormats")]
    public class BookFormat
    {
        public int BookFormatId { get; set; }
    }
}

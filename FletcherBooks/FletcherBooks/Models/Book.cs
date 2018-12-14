using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FletcherBooks.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string isbn10 { get; set; }
        public string isbn13 { get; set; }

        public Book()
        {

        }
        
    }
}

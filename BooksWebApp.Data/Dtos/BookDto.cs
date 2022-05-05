using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApp.Data.Dtos
{
    public class BookDto
    {
        public long? Isbn { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Author { get; set; }
        public string Published { get; set; }
        public string Publisher { get; set; }
        public string Pages { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string Reviews { get; set; }
        public int? Stars { get; set; }
    }
}

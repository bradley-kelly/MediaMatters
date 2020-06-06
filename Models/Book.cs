using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public long ISBN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BookTitle { get; set; }
        public string Edition { get; set; }
        public string DatePublished { get; set; }
        public string CoverImage { get; set; }
        public string Notes { get; set; }
    }
}

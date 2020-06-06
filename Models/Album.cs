using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumTitle { get; set; }
        public string Artist { get; set; }
        public string CoverImage { get; set; }
        public string Notes { get; set; }
    }
}

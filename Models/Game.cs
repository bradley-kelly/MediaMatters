using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string GameTitle { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string DateReleased { get; set; }
        public string Genre { get; set; }
        public string CoverImage { get; set; }
        public string Notes { get; set; }


    }
}

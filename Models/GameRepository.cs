using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class GameRepository : IGameRepository
    {

        public IEnumerable<Game> getGames() =>
            new List<Game>
            {
                new Game{ GameID=1, GameTitle="Civilization V", Developer="Firaxis Games", Publisher="2K Games", DateReleased="September 21, 2010", Genre="Turn-based strategy", CoverImage="", Notes=""},
                new Game{ GameID=2, GameTitle="RimWorld", Developer="Ludeon Studios", Publisher="Ludeon Studios", DateReleased="October 17, 2018", Genre="Construction and management simulation", CoverImage="", Notes=""},
                new Game{ GameID=3, GameTitle="Crusader Kings 2", Developer="Paradox Development Studio", Publisher="Paradox Interactive", DateReleased="February 14, 2012", Genre="Grand strategy", CoverImage="", Notes=""},
                new Game{ GameID=4, GameTitle="The Witcher 3: Wild Hunt", Developer="CD Projekt Red", Publisher="CD Projekt", DateReleased="May 19, 2015", Genre="Action role-playing", CoverImage="", Notes=""},
                new Game{ GameID=5, GameTitle="Call of Duty: Modern Warfare 2", Developer="Infinity Ward", Publisher="Activision", DateReleased="November 10, 2009", Genre="First-person shooter", CoverImage="", Notes=""},
            };

        public Game getGameByID(int ID)
        {
            return getGames().FirstOrDefault(p => p.GameID == ID);
        }
    }
}

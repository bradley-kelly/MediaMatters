using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public interface IGameRepository
    {
        IEnumerable<Game> getGames();
        Game getGameByID(int ID);
    }
}

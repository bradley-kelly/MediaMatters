using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> getAlbums();
        Album getAlbumByID(int ID);
    }
}

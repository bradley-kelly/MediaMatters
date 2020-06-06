using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class AlbumRepository : IAlbumRepository
    {

        public IEnumerable<Album> getAlbums() =>
            new List<Album>
            {
                new Album{ AlbumID=1, AlbumTitle="Is This It", Artist="The Strokes", CoverImage="", Notes=""},
                new Album{ AlbumID=2, AlbumTitle="Kid A", Artist="Radiohead", CoverImage="", Notes=""},
                new Album{ AlbumID=3, AlbumTitle="Blue Album", Artist="Weezer", CoverImage="", Notes=""},
                new Album{ AlbumID=4, AlbumTitle="Kind Of Blue", Artist="Miles Davis", CoverImage="", Notes=""},
                new Album{ AlbumID=5, AlbumTitle="Abbey Road", Artist="The Beatles", CoverImage="", Notes=""},
            };

        public Album getAlbumByID(int ID)
        {
            return getAlbums().FirstOrDefault(p => p.AlbumID == ID);
        }
    }
}

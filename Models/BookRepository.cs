using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class BookRepository : IBookRepository
    {

        public IEnumerable<Book> getBooks() =>
            new List<Book>
            {
                new Book{ BookID=1, ISBN=9780451524935, FirstName="George", LastName="Orwell", BookTitle="1984", Edition="Signet Classic", DatePublished="January 1, 1961", CoverImage="", Notes=""},
                new Book{ BookID=2, ISBN=9780451526342, FirstName="George", LastName="Orwell", BookTitle="Animal Farm", Edition="Signet; 50th Anniversary edition", DatePublished="January 1, 1996", CoverImage="", Notes=""},
                new Book{ BookID=3, ISBN=9780441172719, FirstName="Frank", LastName="Herbert", BookTitle="Dune", Edition="Ace Special 25th Anniversary ed edition", DatePublished="August 26, 2006 ", CoverImage="", Notes=""},
                new Book{ BookID=4, ISBN=9780385732550, FirstName="Lois", LastName="Lowry", BookTitle="The Giver", Edition="Ember; Reissue edition", DatePublished="January 24, 2006", CoverImage="", Notes=""},
                new Book{ BookID=5, ISBN=9780544003415, FirstName="John", LastName="Tolkien", BookTitle="The Lord of the Rings", Edition="Mariner Books; Anniversary edition", DatePublished="August 14, 2012", CoverImage="", Notes=""},
            };

        public Book getBookByID(int ID)
        {
            return getBooks().FirstOrDefault(p => p.BookID == ID);
        }
    }
}

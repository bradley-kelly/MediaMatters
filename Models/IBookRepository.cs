using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> getBooks();
        Book getBookByID(int ID);
    }
}

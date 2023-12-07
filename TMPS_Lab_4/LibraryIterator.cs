using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_4
{
    public class LibraryIterator : IBookIterator
    {
        private readonly List<Book> _books;
        private int _current = 0; // Tracks the current position in the iteration.

        public LibraryIterator(List<Book> books)
        {
            _books = books;
        }

        public bool HasNext()
        {
            return _current < _books.Count; // Checks if more books are available for iteration.
        }

        public Book Next()
        {
            return _books[_current++]; // Returns the next book and increments the index.
        }
    }
}

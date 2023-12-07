using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_4
{
    // Library Class implementing Observer
    public class Library : IBookObserver
    {
        public List<Book> _books = new List<Book>(); // Collection of books in the library.
        private ISortingStrategy _sortingStrategy; // Current sorting strategy.

        public Library(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy; // Setting the initial sorting strategy.
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
            book.AttachObserver(this); // Attaching itself as an observer to the book.
        }

        public void SetSortingStrategy(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy; // Changing the sorting strategy.
        }

        public void SortBooks()
        {
            _sortingStrategy.Sort(_books); // Sorting books using the current strategy.
        }

        public IBookIterator CreateIterator()
        {
            return new LibraryIterator(_books); // Creating an iterator for books.
        }

        public void Update(Book book)
        {
            Console.WriteLine($"Notification: '{book.Title}' is now {book.Status}."); // Observer update method.
        }
    }
}

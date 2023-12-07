using System;
using System.Collections.Generic;
using TMPS_Lab_4;

// Example Usage
class Program
{
    static void Main(string[] args)
    {
        var library = new Library(new TitleSortStrategy()); // Using title sort strategy.
        // Adding books.
        library.AddBook(new Book("Design Patterns"));
        library.AddBook(new Book("Clean Code"));
        library.AddBook(new Book("Refactoring"));

        library.SortBooks(); // Sorting the books.

        // Iterating over books.
        var iterator = library.CreateIterator();
        while (iterator.HasNext())
        {
            var book = iterator.Next();
            Console.WriteLine($"Book: {book.Title}");
        }

        Console.WriteLine();
        // Changing book status and observing the effect.
        library._books[0].ChangeStatus("Checked Out");

        Console.WriteLine();
        // Switching to a different sorting strategy.
        library.SetSortingStrategy(new StatusSortStrategy());
        library.SortBooks();

        // Iterating again with the new sorting strategy.
        iterator = library.CreateIterator();
        while (iterator.HasNext())
        {
            var book = iterator.Next();
            Console.WriteLine($"Book: {book.Title}, Status: {book.Status}");
        }
    }
}

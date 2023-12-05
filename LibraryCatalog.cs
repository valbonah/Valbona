using LibraryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    // The LibraryCatalog class represents the catalog of books available in the library.
    public class LibraryCatalog
    {
        // Private field to store the list of books in the catalog.
        private List<Book> books = new List<Book>();

        // Constructor to initialize books in the library catalog.
        public LibraryCatalog()
        {
            // Adding initial books to the catalog.
            books.Add(new Book { Title = "Piramida", Author = "Ismail Kadare" });
            books.Add(new Book { Title = "Prilli i Thyer", Author = "Ismail Kadare" });
            books.Add(new Book { Title = "Keshtjella", Author = "Ismail Kadare" });
        }

        // DisplayCatalog method prints the details of books in the library catalog.
        public void DisplayCatalog()
        {
            Console.WriteLine("Library Catalog:");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} - {(book.IsAvailable ? "Available" : "Borrowed")}");
            }
        }

        // GetBookByTitle method retrieves a book from the catalog based on its title.
        public Book GetBookByTitle(string title)
        {
            return books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        // BorrowBook method allows a user to borrow a book from the library.
        public void BorrowBook(string title)
        {
            var book = GetBookByTitle(title);
            if (book != null && book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine($"Book '{book.Title}' borrowed successfully.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' is not available for borrowing.");
            }
        }
    }
}

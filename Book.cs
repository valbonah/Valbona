using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibraryProject
{
    // The ILibrarySystem interface outlines the methods that a library system should implement.
    public interface ILibrarySystem
    {
        // The Login method is responsible for authenticating a user into the library system.
        void Login(string username, string password);

        // The BrowseBooks method allows users to view the available books in the library.
        void BrowseBooks();

        // The BorrowBook method is used to borrow a specific book from the library.
        void BorrowBook(string bookTitle);
    }
}

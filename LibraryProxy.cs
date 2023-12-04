using LibraryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryProject
{
    // The LibraryProxy class acts as a proxy for the library system, implementing the ILibrarySystem interface.
    public class LibraryProxy : ILibrarySystem
    {
        // Private fields to store an instance of LibraryCatalog, UserManager, and the logged-in user.
        private readonly LibraryCatalog _libraryCatalog = new LibraryCatalog();
        private readonly UserManager _userManager = new UserManager();
        private string _loggedInUser;

        // Implementation of the Login method from the ILibrarySystem interface.
        public void Login(string username, string password)
        {
            // Authenticate the user using the UserManager.
            if (_userManager.AuthenticateUser(username, password))
            {
                _loggedInUser = username;
            }
            else
            {
                Console.WriteLine("Authentication failed. Please check your username and password.");
            }
        }

        // Implementation of the BrowseBooks method from the ILibrarySystem interface.
        public void BrowseBooks()
        {
            // Display the catalog using the LibraryCatalog instance.
            _libraryCatalog.DisplayCatalog();
        }

        // Implementation of the BorrowBook method from the ILibrarySystem interface.
        public void BorrowBook(string bookTitle)
        {
            // Get the user role using the UserManager.
            string userRole = _userManager.GetUserRole(_loggedInUser);

            // Check user role to determine borrowing eligibility.
            if (userRole == "Student")
            {
                Console.WriteLine("Students are not allowed to borrow books directly. Request approval.");
            }
            else if (userRole == "Professor")
            {
                // Borrow a book from the catalog if the user is a Professor.
                _libraryCatalog.BorrowBook(bookTitle);
            }
            else
            {
                Console.WriteLine("User role not recognized. Unable to borrow a book.");
            }
        }
    }
}

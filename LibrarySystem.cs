using LibraryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject    
{
    public class LibrarySystem : ILibrarySystem
    {
        private readonly LibraryCatalog _libraryCatalog = new LibraryCatalog();
        private readonly LibraryMemberManager _memberManager = new LibraryMemberManager();
        private string _loggedInUser;

        public void Login(string username, string password)
        {
            // Implement login logic
            _loggedInUser = username;
        }

        public void BrowseBooks()
        {
            _libraryCatalog.DisplayCatalog();
        }

        public void BorrowBook(string bookTitle)
        {
            string userRole = GetUserRole(_loggedInUser);

            if (userRole == "Student")
            {
                Console.WriteLine("Students are not allowed to borrow books directly. Request approval.");
            }
            else if (userRole == "Professor")
            {
                _libraryCatalog.BorrowBook(bookTitle);
            }
            else
            {
                Console.WriteLine("User role not recognized. Unable to borrow a book.");
            }
        }

        private string GetUserRole(string username)
        {
            LibraryMember member = _memberManager.GetMemberByName(username);

            if (member is Student)
            {
                return "Student";
            }
            else if (member is Professor)
            {
                return "Professor";
            }

            return "Unknown";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryProject
{
    // The LibraryClient class represents a client of the library system.
    public class LibraryClient
    {
        // Constructor for the LibraryClient class.
        public LibraryClient() { }

        // UseLibrarySystem method demonstrates the usage of the library system by registering users,
        // creating a proxy, and performing login and book-related operations.
        public void UseLibrarySystem()
        {
            // Create instances of UserManager and LibraryProxy.
            UserManager userManager = new UserManager();
            LibraryProxy libraryProxy = new LibraryProxy();

            // Register users (student and professor).
            Student student = new Student("student123");
            Professor professor = new Professor("professor456");

            userManager.AddStudent(student);
            userManager.AddProfessor(professor);

            // Register members with LibraryMemberManager.
            LibraryMemberManager memberManager = new LibraryMemberManager();
            memberManager.AddMember(student);
            memberManager.AddMember(professor);

            // Student login and browse books using the proxy.
            libraryProxy.Login("student123", "password");
            libraryProxy.BrowseBooks();

            // Professor login and try to borrow a book using the proxy.
            libraryProxy.Login("professor456", "password");
            libraryProxy.BorrowBook("Book1");

            // Student login and try to borrow a book using the real object (commented out).
            // Removed librarySystem usage
            // librarySystem.Login("student123", "password");
            // librarySystem.BorrowBook("Book2");
        }
    }
}

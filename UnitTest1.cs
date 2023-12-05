using NUnit.Framework; // Adjust this based on your testing framework

namespace LibraryProject.Tests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void BookProperties_AreSetCorrectly()
        {
            // Arrange
            var book = new Book();

            // Act
            book.Title = "TestTitle";
            book.Author = "TestAuthor";
            book.IsAvailable = false;

            // Assert
            Assert.AreEqual("TestTitle", book.Title);
            Assert.AreEqual("TestAuthor", book.Author);
            Assert.IsFalse(book.IsAvailable);
        }

        [Test]
        public void BookIsAvailable_ByDefault()
        {
            // Arrange
            var book = new Book();

            // Assert
            Assert.IsTrue(book.IsAvailable);
        }
        
        [Test]
        public void GetBookByTitle_NonexistentTitle_ReturnsNull()
        {
            // Arrange
            var libraryCatalog = new LibraryCatalog();

            // Act
            var nonExistentBook = libraryCatalog.GetBookByTitle("NonExistentTitle");

            // Assert
            Assert.IsNull(nonExistentBook);
        }
        public void AddMember_NewMember_AddsToMemberList()
        {
            // Arrange
            var memberManager = new LibraryMemberManager();
            var newStudent = new Student("NewStudent123");

            // Act
            memberManager.AddMember(newStudent);
            var retrievedMember = memberManager.GetMemberByName("NewStudent123");

            // Assert
            Assert.IsNotNull(retrievedMember);
            Assert.AreEqual(newStudent, retrievedMember);
        }
        [Test]
        public void GetMemberByName_ExistingMember_ReturnsCorrectMember()
        {
            // Arrange
            var memberManager = new LibraryMemberManager();
            var existingProfessor = new Professor("ExistingProfessor");
            memberManager.AddMember(existingProfessor);

            // Act
            var retrievedMember = memberManager.GetMemberByName("ExistingProfessor");

            // Assert
            Assert.IsNotNull(retrievedMember);
            Assert.AreEqual(existingProfessor, retrievedMember);
        }








        [Test]
        public void BorrowBook_BookNotAvailable_ReturnsErrorMessage()
        {
            // Arrange
            var libraryCatalog = new LibraryCatalog();
            var bookTitle = "Book3";

            // Act
            libraryCatalog.BorrowBook(bookTitle);
            libraryCatalog.BorrowBook(bookTitle); // Attempt to borrow the same book again

            // Assert
           
        }
    }
}

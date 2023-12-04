
using LibraryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    // The UserManager class manages students and professors in a library system.
    public class UserManager
    {
        // Lists to store instances of Student and Professor classes.
        private List<Student> students;
        private List<Professor> professors;

        // Constructor initializes lists and loads users from a data source if needed.
        public UserManager()
        {
            students = new List<Student>();
            professors = new List<Professor>();
        }

        // Method to add a Student to the list of students.
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // Method to add a Professor to the list of professors.
        public void AddProfessor(Professor professor)
        {
            professors.Add(professor);
        }

        // Method to authenticate users. For simplicity, all users are assumed to be authenticated.
        public bool AuthenticateUser(string username, string password)
        {
            return true;
        }

        // Method to determine the role of a user based on their username.
        public string GetUserRole(string username)
        {
            if (students.Any(s => s.Name == username))
            {
                return "Student";
            }
            else if (professors.Any(p => p.Name == username))
            {
                return "Professor";
            }

            return "Unknown";
        }
    }
}

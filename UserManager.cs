using LibraryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject    
{
    public class UserManager
    {
        private List<Student> students;
        private List<Professor> professors;

        public UserManager()
        {
            // Initialize lists and load users from a data source if needed
            students = new List<Student>();
            professors = new List<Professor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddProfessor(Professor professor)
        {
            professors.Add(professor);
        }

        public bool AuthenticateUser(string username, string password)
        {
            // Implement authentication logic, for simplicity, let's assume all users are authenticated
            return true;
        }

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

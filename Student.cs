
using LibraryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    // The Student class represents a student who is a library member.
    public class Student : LibraryMember
    {
        // Constructor for the Student class, taking the student's name as a parameter.
        public Student(string name) : base(name) { }
    }
}

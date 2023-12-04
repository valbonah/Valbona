using LibraryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    // The LibraryMemberManager class manages a collection of library members.
    public class LibraryMemberManager
    {
        // Private field to store a list of library members.
        private List<LibraryMember> members = new List<LibraryMember>();

        // Method to add a library member to the collection.
        public void AddMember(LibraryMember member)
        {
            members.Add(member);
        }

        // Method to get a library member by their name.
        public LibraryMember GetMemberByName(string name)
        {
            // Using LINQ to find the library member with a matching name (case-insensitive).
            return members.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}

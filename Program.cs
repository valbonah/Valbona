// See https://aka.ms/new-console-template for more information
using LibraryProject;


namespace LibraryProject    
{
    class Program
    {
        static void Main()
        {
            // Your code to initialize and run the application
            LibraryClient client = new LibraryClient();
            client.UseLibrarySystem();
        }
    }
}

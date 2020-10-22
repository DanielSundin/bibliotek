using System;

namespace Biblioteket
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Biblioteket!!");
            
            Library library = new Library();

            library.LoadSampleLibrary();

            library.PrintLibraryContents();

        }
    }
}
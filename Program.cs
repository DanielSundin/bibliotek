using System;
using System.Collections.Generic;

namespace Biblioteket
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Biblioteket!!");

            Library library = new Library();

            library.LoadSampleLibrary();             
            library.AddListofBooks(library.sampleList);
           
            Console.Clear();
           
            List<Book> librarycontents = library.PrintLibraryContents();

            foreach (Book b in librarycontents)
            {
                Console.WriteLine(b);
            }   //varje klass har overload av ToString för att få olika resultat

        }
    }
}
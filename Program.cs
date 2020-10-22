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

            List<Book> librarycontents = library.PrintLibraryContents();
            foreach (Book b in librarycontents)
                {                    
                    Console.WriteLine($"{b.Title}, av {b.Author}. Utgiven {b.Publicationyear}");
                    //System.Console.WriteLine($"[{booksinLibrary.IndexOf(b)}]: {b.Title}");
                }   //returnera detta istället för att skriva

        }
    }
}
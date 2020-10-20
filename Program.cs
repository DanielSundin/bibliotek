using System;

namespace Biblioteket
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Biblioteket!!");
            Library library = new Library();
            library.AddBook("A game of thrones", 1996, "George R. R. Martin");
            library.AddBook("The Hydrogen Sonata", 2012, "Ian M. Banks");
            library.AddBook("Frankenstein", 2002, "Mary Shelley");
            library.AddBook("Three Moments of an Explosion", 2015, "China Mieville");
            library.AddBook("c/o HOPS", 2020, "Me and my magazines");
        }
    }
}
using System.Collections.Generic;

namespace Biblioteket
{
public class Library
{
    private List <Book> booksinLibrary = new List<Book>();
     

    public void AddBook(string title, int publicationyear, string author)
    {
        Book book = new Book(title, publicationyear, author);
        book.Title=title;
        book.Publicationyear = publicationyear;
        book.Author = author;
        booksinLibrary.Add(book);
    }
    public void AddListofBooks()
    {

    }

    public void PrintLibraryContents()
    {
        foreach (Book b in booksinLibrary)
        {
            System.Console.WriteLine($"{b.Title}, av {b.Author}. Utgiven {b.Publicationyear}" );
            //System.Console.WriteLine($"[{booksinLibrary.IndexOf(b)}]: {b.Title}");
        }    //returnera detta istället för att skriva
    }

    public static void SearchLibrary()
    {
        
    }

    internal void LoadSampleLibrary()
    {
        AddBook("A Game of Thrones", 1996, "George R. R. Martin");
        AddBook("The Hydrogen Sonata", 2012, "Ian M. Banks");
        AddBook("Frankenstein", 2002, "Mary Shelley");
        AddBook("Three Moments of an Explosion", 2015, "China Mieville");
        AddBook("c/o HOPS", 2020, "Me and my magazines");
        //gör sedan detta till underklasser
    }
}
}
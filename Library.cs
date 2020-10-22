using System.Collections.Generic;
using System.Linq;

namespace Biblioteket
{
public class Library
{
    private List <Book> booksinLibrary = new List<Book>();
    public List<Book> sampleList = new List<Book>();

    public void AddBook(string title, int publicationyear, string author)
    {
        Book book = new Book(title, publicationyear, author);
        book.Title=title;
        book.Publicationyear = publicationyear;
        book.Author = author;
        booksinLibrary.Add(book);
    }
    public void AddListofBooks(List<Book> input)
    {           
        booksinLibrary=booksinLibrary.Union(input).ToList();
    }  //denna metod använder union för att inkludera en input sträng av böcker i booksinLibrary, samt undvika dubletter

    public List<Book> PrintLibraryContents()
    {
        return booksinLibrary;
    }

    public static void SearchLibrary()
    {
        
    }

    internal void LoadSampleLibrary()
    {
        AddBook("A Game of Thrones", 1996, "George R. R. Martin");
        AddBook("The Hydrogen Sonata", 2012, "Ian M. Banks");
        AddBook("Frankenstein", 2002, "Mary Shelley");
        
        
        Book book3 = new Book( "Three Moments of an Explosion", 2015, "China Mieville");
        Book book4 = new Book("c/o HOPS", 2020, "Me and my magazines");
        sampleList.Add(book3);
        sampleList.Add(book4);
        //gör sedan detta till underklasser
        
    }
}
}
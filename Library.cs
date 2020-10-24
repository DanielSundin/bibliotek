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
    }  //denna metod använder .Union för att inkludera en input sträng av böcker i booksinLibrary, samt undvika dubletter
       //man skulle i denna metod kunna lägga till en dataAccess funktion för att spara i en extern fil
       // och åt andra hållet skulle en filhanteringsmetod kunna skicka in en fil som "input"
    public List<Book> PrintLibraryContents()
    {
        return booksinLibrary;
    }

    public static void SearchLibrary()
    {
        
    }

    internal void LoadSampleLibrary()
    {
        AddBook("Three Moments of an Explosion", 2015, "China Mieville", 1);
        AddBook("The Hydrogen Sonata", 2012, "Ian M. Banks", "scifi");
        AddBook("c/o HOPS", 2020, "Me and my magazines", 50, 10);
                
        Book book3 = new Novel("A Game of Thrones", 1996, "George R. R. Martin", "fantasy");
        Book book4 = new Novel("Frankenstein", 2002, "Mary Shelley", "skräck");
        sampleList.Add(book3);
        sampleList.Add(book4);
                
    }
        public void AddBook(string title, int publicationyear, string author, string genre)
    {
        Novel book = new Novel(title, publicationyear, author, genre);
        book.Title=title;      
        book.Publicationyear = publicationyear;
        book.Author = author;
        book.Genre = genre;
        booksinLibrary.Add(book);
    }
        public void AddBook(string title, int publicationyear, string compiler, int authorcount)
    {
        Anthology book = new Anthology(title, publicationyear, compiler, authorcount);
        book.Title=title;      
        book.Publicationyear = publicationyear;
        book.Compiler = compiler;
        book.AuthorCount= authorcount;
        booksinLibrary.Add(book);
    }
        public void AddBook(string title, int publicationyear, string author, int number, int month)
    {
        Periodical book = new Periodical(title, publicationyear, author, number, month);
        book.Title=title;      
        book.Publicationyear = publicationyear;
        book.Author = author;
        book.Number = number;
        book.Month = month;
        booksinLibrary.Add(book);
    }
}
}
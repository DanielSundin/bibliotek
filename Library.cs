using System.Collections.Generic;

namespace Biblioteket
{
public class Library
{
    public List <Book> booksinLibrary = new List<Book>();
    Library library = new Library();
    
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

    public static void PrintLibraryContents()
    {

    }

    public static void SearchLibrary()
    {
        
    }
}
}
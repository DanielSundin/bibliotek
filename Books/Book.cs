namespace Biblioteket
{
    public class Book
    {                   //egentligen hade det varit trevligt att göra denna klass abstract för att tvinga in kategorisering
        public string Title { get; set; }
        public int Publicationyear { get; set; }
        public string Author { get; set; }

       // public Book() { }       //do I need this?
        public Book(string title, int publicationyear, string author)
        {
            Title = title;
            Publicationyear = publicationyear;
            Author = author;
        }

    }
}
namespace Biblioteket
{
    public class Book
    {                   //det hade det varit möjligt att göra denna klass abstract för att tvinga in kategorisering
        public string Title { get; set; }
        public int Publicationyear { get; set; }
        public string Author { get; set; }

        public Book(string title, int publicationyear, string author)
        {
            Title = title;
            Publicationyear = publicationyear;
            Author = author;
        }
        public override string ToString()
        {
            return Title + " av " + Author + " från " + Publicationyear;
        }
    }
}
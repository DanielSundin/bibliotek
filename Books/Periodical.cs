namespace Biblioteket
{
    class Periodical : Book
    {
        int number;

        public Periodical(string title, int publicationyear, string author, int number) : base(title, publicationyear, author)
        {
        }
    }
}
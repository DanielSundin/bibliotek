    namespace Biblioteket
{
    class Novel : Book
    {
        string genre;

        public Novel(string title, int publicationyear, string author, string genre) : base(title, publicationyear, author)
    {
        
    }
    }
}
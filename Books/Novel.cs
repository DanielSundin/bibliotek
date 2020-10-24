namespace Biblioteket
{
    class Novel : Book
    {
        public string Genre
        { get; set; }

        public Novel(string title, int publicationyear, string author, string genre) : base(title, publicationyear, author)
        {
            Genre = genre;
        }


        public override string ToString()
        {
            return Title + " av " + Author + " från " + Publicationyear +", genre: "+ Genre;
        }
    }

}
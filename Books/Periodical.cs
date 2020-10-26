namespace Biblioteket
{
    class Periodical : Book
    {
        public int Number
        {get; set;}
        
        public int Month
        {get; set;}       

        public Periodical(string title, int publicationyear, string author, int number, int month) : base(title, publicationyear, author)
        {
            Number = number;
            Month = month;
        }
        public override string ToString()
        {
            return Title + " av " + Author + " från " + Publicationyear+", nummer: "+ Number +" månad: "+ Month;
        }
    }
}
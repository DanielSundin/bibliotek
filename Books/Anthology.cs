
namespace Biblioteket
{
    class Anthology : Book
    {
        public int AuthorCount
        {get; set;} 
        public string Compiler      
        {                            
            get {return this.Author;}
            set {this.Author = value;}
        }  // byter namn på variabeln author till compiler (sammanställare)

        public Anthology(string title, int publicationyear, string compiler, int authorCount) : base(title, publicationyear, compiler)
        {
            AuthorCount = authorCount;
        }
        public override string ToString()
        {
            return Title + " sammanställd av " + Compiler + " från " + Publicationyear +". Antal författare: " + AuthorCount ;
        }
        
    }
}
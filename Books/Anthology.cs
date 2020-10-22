
namespace Biblioteket
{
    class Anthology : Book
    {
          
        public string Publisher      
        {                            
            get {return this.Author;}
            set {this.Author = value;}
        }  // byter namn på variabeln author till publisher

        public Anthology(string title, int publicationyear, string publisher) : base(title, publicationyear, publisher)
        {
        }
        
    }
}
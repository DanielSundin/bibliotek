using System.Collections.Generic;
namespace Biblioteket
{
    class Anthology : Book
    {
           
        public string Publisher      
        {           //byter namn på variabeln author till publisher
            get {return this.Author;}
            set {this.Author = value;}
        }

        public Anthology(string title, int publicationyear, string publisher) : base(title, publicationyear, publisher)
        {
        }

        
    }
}
using System;
using System.Collections.Generic;

namespace Biblioteket
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hej och välkommen till Biblioteket!");
            PrintMenu();
        }
        public static void PrintMenu()
        {
            Library library = new Library();
            library.LoadSampleLibrary();
            library.AddListofBooks(library.sampleList);

            while (true)
            {
                Console.WriteLine("Det finns 3 olika alternativ:");
                Console.WriteLine(" A: Skriv ut en lista över bibliotekets alla böcker.");
                Console.WriteLine(" B: Lägg till en bok.");
                Console.WriteLine(" C: Sök i biblioteket efter en särskilt titel.");
                Console.WriteLine("Skriv nu ditt val eller Q för att avsluta.");

                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "A":
                        {
                            Console.Clear();
                            Console.WriteLine("BIBLIOTEKET INNEHÅLLER:\n");

                            List<Book> librarycontents = library.PrintLibraryContents();

                            foreach (Book b in librarycontents)
                            {
                                Console.WriteLine(b);
                            }   //varje klass har overload av ToString för att få olika resultat
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "B":
                        {
                            Book userbook = new Book("", 0, "");                //sätter lite defaultvärden på hypotetiska objekt
                            //Novel usernovel = new Novel("",0,"","");
                            //Anthology useranthology = new Anthology("",0,"",1);
                            //Periodical userperiodical = new Periodical("", 0, "", 0, 0);

                            Console.Clear();
                            Console.WriteLine("Du har valt att lägga till en ny bok.\n");
                            Console.WriteLine("Följande information krävs = titel, författare, utgivningsår.");
                            Console.WriteLine("Följande information är inte obligatorisk men kan tilläggas = antal författare (i fall av antologier),\ngenre (i fall av romaner), och i fall av tidsskrifter - dess nummer och utgivningsmånad.\n");

                            Console.WriteLine("Fyll i bokens TITEL: ");
                            userbook.Title = Console.ReadLine();
                            Console.WriteLine("Fyll i bokens FÖRFATTARE: ");
                            userbook.Author = Console.ReadLine();
                            Console.WriteLine("Fyll i bokens UTGIVNINGSÅR: ");
                            userbook.Publicationyear = Convert.ToInt32(Console.ReadLine());   //FELHANTERING IFSATS

                            Console.Clear();
                            Console.WriteLine("Du har fyllt i följande information:\n");
                            Console.WriteLine("\nTITEL: " + userbook.Title + "\nFÖRFATTARE: " + userbook.Author + "\nUTGIVNINGSÅR: " + userbook.Publicationyear);
                            Console.WriteLine("\nSkulle du vilja lägga till boken i biblioteket? Tryck i så fall J. Tryck annars N.");
                            string choice = Console.ReadLine().ToLower();
                            if (choice == "j")
                            {
                                library.AddBook(userbook.Title, userbook.Publicationyear, userbook.Author);
                                Console.WriteLine("Boken är nu tillagd i biblioteket!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (choice == "n")
                            {
                                Console.WriteLine("Informationen raderad.");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            // else if (choice == "y")         //Undermeny för att skapa mer avancerade objekt
                            // {

                            // }
                           
                            else
                            {
                                Console.WriteLine("Något har gått fel. Du tas nu tillbaka till huvudmenyn.");
                                Console.ReadKey();
                            }

                            Console.ReadKey();
                            break;
                        }
                    case "C":
                        {
                            Library.SearchLibrary();
                            break;
                        }

                    case "Q":
                        {
                            Console.WriteLine("Avslutar programmet");
                            Console.ReadKey();
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Var god välj alternativ A,B eller C alt avsluta med Q");
                            Console.ReadKey();
                            break;
                        }

                }
            }
        }
    }

    
}

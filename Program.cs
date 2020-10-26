﻿using System;
using System.Collections.Generic;

namespace Biblioteket
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Hej och välkommen till Biblioteket!");
            Console.WriteLine("Tryck enter!");
            Console.ReadKey();
            PrintMenu();
        }
        public static void PrintMenu()
        {
            Library library = new Library();
            library.LoadSampleLibrary();
            library.AddListofBooks(library.sampleList);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Det finns 3 olika alternativ:");
                Console.WriteLine(" A: Skriv ut en lista över bibliotekets alla böcker.");
                Console.WriteLine(" B: Lägg till en bok.");
                Console.WriteLine(" C: Sök i biblioteket efter en särskild titel.");
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
                            //Anthology useranthology = new Anthology("",0,"",1);  //i en utökning kan man lägga till fler funktioner för att skapa mer avancerade objekt
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

                            try
                            {
                                userbook.Publicationyear = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Var god fyll i ett utgivningsår, med heltal. Var god försök igen.");
                                Console.ReadKey();
                                break;
                            }

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
                            // else if (choice == "y")         //Plats för undermeny för att skapa mer avancerade objekt
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
                            Console.Clear();
                            Console.WriteLine("Skriv in en boktitel att söka efter (Det går även att söka på författare eller utgivningsår):\n");
                            string search = Console.ReadLine().ToLower();

                            List<Book> librarycontents = library.PrintLibraryContents();

                            if (library.SearchLibrary(search) == true)
                            {
                                System.Console.WriteLine("Sökningen gav dessa träffar: ");

                                foreach (Book b in library.searchResults)
                                {
                                    {
                                        Console.WriteLine(b);
                                    }
                                }
                                library.searchResults.Clear();
                                Console.ReadKey();
                            }
                            else
                            {
                                System.Console.WriteLine("Tyvärr ingen träff");
                                Console.ReadKey();
                            }

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

# Inlämningsuppgift - Biblioteket
Elev: Daniel Sundin, SUV.NET2020

## Uppgiftsbeskrivning

Uppgiften var att skapa ett C#-program som skulle simulera ett filhanteringssystem i ett bibliotek, med möjlighet att lägga till, skriva ut och söka bland bibliotekets böcker. Nedan följer vilka funktionskrav som programmet uppfyller.




## Funktionskrav
1. Programmet innehåller en klass _Book_. Den har tre egenskaper: titel, författare och utgivningsår. (Book.cs rad 5)
2. Det finns tre underklasser: roman, tidsskrift och antologi.
(Anthology.cs, Novel.cs, Periodical.cs)
3. Programmet innehåller en klass vid namn _Library_ som innehåller en privat lista med _Book_-er. (Library.cs rad 8)
4. _Library_-klassen innehåller en publik metod för att lägga till ett bokobjekt. (Library.cs rad 11. Overload för underklasser rad 62, 71, 80)
5. _Library_-klassen innehåller en publik metod för att lägga till en lista av bokobjekt. (Library.cs rad 19)
6. _Library_-klassen innehåller en publik metod för att skriva ut alla bibliotekets bokobjekt. (Library.cs rad 25)
7. _Library_-klassen innehåller en publik metod för att söka i samlingen efter given indata. (Library.cs rad 30)
8. Varje underklass innehåller en separat _ToString_override. (Book.cs rad 15, Anthology.cs rad 18, Novel.cs rad 14, Periodical.cs rad 17)
9. Genom en konsolmeny kan användaren lägga till nya böcker.v (Program.cs rad 51)
10. Genom en konsolmeny kan användaren skriva ut alla böcker i samlingen. (Program.cs rad 35)
11. Genom en konsolmeny kan användaren söka efter en boktitel. Det går att söka på titel, författare eller utgivningsår (och även på attribut från underklasserna). Sökmetoden ser ingen skillnad på versaler och gemener. (Program.cs rad 113)
12. När användaren skapar ett objekt är den av klassen _Book_. (Program.cs rad 87)
13. Programmet innehåller en färdigkonfigurerad lista med 5 olika böcker, från alla underklasser. (Library.cs rad 9)


---

## Diskussion

Programmet innehåller, förutom library-klassen, en basklass (book) och tre underklasser. Underklasserna har lite extra attribut, separata konstruktorer och egna ToString Overrides. Eftersom de har egna konstruktorer har jag också gjort _overload_ metoder för att skapa objekt av varje underklass. I fall att man skulle vilja utöka programmet, kan dessa användas om en användare vill skapa objekt av en underklass istället för av en Book-klass. 

Vill man undvika att det finns "odefinierade" Book-objekt så kan man göra klassen Book abstrakt. Då är man tvungen att göra ett specifierat objekt, vilket kan vara önskvärt.

Funktionen för att lägga till en lista av böcker använder sig av metoden .Union som lägger ihop två listor utan att lägga till dubletter.

Konsolmenyn skulle kunna brytas ut i en separat klass. Jag gjorde så till en start, men det då blev Program.cs en klass som bara innehöll 2 anrop till andra klasser. Konsolmenyn hade sett bättre ut av att delas upp i separata funktioner istället för nästlade if-satser. Jag har valt att inte försöka mig på det.

 Sökfunktionen letar genom all data attriberad objekten. Sökningen görs med funktionen .Contains som returnerar sant/falskt. Metoden jämför en sökvariabel i strängformat mot sträng-konverterade värden i bibliotekets boklista. Det gör att man kan få en träff på siffervärden också, t ex kan en sökning på 1984 returnera både Orwells roman och en bok som publicerats det årtalet.
 En loop söker genom listan över bibliotekets alla böcker och lägger till de resultat som returnerar _true_ i en annan lista vid namn Library.searchResults. Denna lista returneras till konsolmenyn och loopas igenom för att skriva ut de träffar som sökningen resulterat i. 

 Vad gäller säkring av felaktig inmatning är den största delen av indata i strängformat. Jag har lagt till en try catch där användaren ska definiera en int-variabel (Program.cs rad 67). MEd det sagt är det nog inga större bekymmer att krascha programmet om man så skulle vilja.

 

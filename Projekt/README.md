# System zarzadzania cyfrowa biblioteka

Aplikacja internetowa do zarzadzania zbiorem ksiazek, zbudowana w technologii ASP.NET Core MVC z wykorzystaniem wzorca architektonicznego Model-View-Controller (MVC). Umozliwia dodawanie, przegladanie, edytowanie i usuwanie ksiazek oraz ich wyszukiwanie. Dane przechowywane sa w bazie SQLite za posrednictwem Entity Framework Core.

## Spis tresci

- [Opis projektu](#opis-projektu)
- [Wykorzystane technologie](#wykorzystane-technologie)
- [Funkcjonalnosci](#funkcjonalnosci)
- [Struktura projektu MVC](#struktura-projektu-mvc)
- [Wymagania](#wymagania)
- [Instrukcja uruchomienia](#instrukcja-uruchomienia)

## Opis projektu

Aplikacja realizuje system zarzadzania cyfrowa biblioteka. Kazda ksiazka opisana jest trzema polami: tytul, autor oraz rok wydania. Aplikacja udostepnia pelen zestaw operacji CRUD (dodawanie, odczyt, edycja, usuwanie) wraz z walidacja danych i wyszukiwarka.

Calosc zbudowana jest zgodnie ze wzorcem MVC, ktory oddziela warstwe danych (Model), logike obslugi zadan (Controller) oraz warstwe prezentacji (View).

## Wykorzystane technologie

- .NET 10
- ASP.NET Core MVC
- Entity Framework Core 
- SQLite 
- Bootstrap 

## Funkcjonalnosci

- Dodawanie ksiazek przez formularz (tytul, autor, rok wydania).
- Przegladanie listy wszystkich ksiazek w formie tabeli.
- Podglad szczegolow pojedynczej ksiazki.
- Edycja danych istniejacej ksiazki.
- Usuwanie ksiazek z potwierdzeniem.
- Walidacja danych po stronie serwera i klienta: sprawdzanie pol wymaganych, dlugosci tekstu oraz zakresu roku wydania + komunikaty bledow.
- Wyszukiwanie ksiazek po tytule lub autorze, niewrazliwe na wielkosc liter.
- Ostylowana tabela z czytelnym ukladem i przyciskami akcji.
- Przycisk "Books" w gornym menu, prowadzacy do listy ksiazek.

## Struktura projektu MVC

- Model: plik Models/Book.cs, klasa reprezentujaca ksiazke (pola Title, Author, Year) wraz z regulami walidacji.
- Kontroler: plik Controllers/BooksController.cs, obsluguje zadania HTTP, komunikuje sie z baza przez AppDbContext i przekazuje dane do widokow. Zawiera logike wyszukiwania.
- Widok: folder Views/Books, widoki listy (Index), szczegolow (Details), dodawania (Create), edycji (Edit) i usuwania (Delete).
- Warstwa danych: plik Data/AppDbContext.cs, kontekst Entity Framework Core odpowiedzialny za komunikacje z baza SQLite.

## Wymagania

Do uruchomienia aplikacji potrzebne sa:

- .NET 10 SDK 

Aplikacja korzysta z nastepujacych pakietow NuGet (instalowane automatycznie przy przywracaniu zaleznosci):

- Microsoft.EntityFrameworkCore.Sqlite 
- Microsoft.EntityFrameworkCore.Tools 
- Microsoft.VisualStudio.Web.CodeGeneration.Design 

## Instrukcja uruchomienia

1. Sklonuj repozytorium:
   ```
   git clone https://github.com/jackom9713327/MVCGlowne.git
   ```
2. Wejdz do podfolderu Projekt i otworz plik .sln w Visual Studio
3. Otworz plik .sln w Visual Studio.
4. Utworz baze danych. Otworz Tools > NuGet Package Manager > Package Manager Console i wpisz:
   ```
   Update-Database
   ```
5. Uruchom aplikacje klawiszem F5.
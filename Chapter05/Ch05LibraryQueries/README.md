# 1. Library Recommendations: Filter, Sort, and Project

Maak eerst de oefening uit hoofdstuk 5 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter05/Ch05LibraryQueries`):

```powershell
dotnet new console --name Ch05LibraryQueries --output Ch05LibraryQueries --framework net10.0
dotnet sln Ch05LibraryQueries.sln add Ch05LibraryQueries/Ch05LibraryQueries.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch05LibraryQueries` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch05LibraryQueries
dotnet test Ch05LibraryQueries.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Book.cs

```csharp
public class Book
public string Code { get; }
public string Title { get; set; }
public bool IsAvailable { get; set; }
public Book(string code, string title, bool isAvailable)
```

### LibraryCatalog.cs

```csharp
public class LibraryCatalog
public int Count { get; }
public bool AddBook(Book? book)
public Book? FindByCode(string code)
public List<Book> GetAvailableBooks()
public List<string> GetAvailableTitles()
public List<string> GetCodes()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

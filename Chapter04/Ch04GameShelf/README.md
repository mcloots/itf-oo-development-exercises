# 2. A Board Game Shelf: Add, Find, and Remove

Maak eerst de oefening uit hoofdstuk 4 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter04/Ch04GameShelf`):

```powershell
dotnet new console --name Ch04GameShelf --output Ch04GameShelf --framework net10.0
dotnet sln Ch04GameShelf.sln add Ch04GameShelf/Ch04GameShelf.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch04GameShelf` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch04GameShelf
dotnet test Ch04GameShelf.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Game.cs

```csharp
public class Game
public string Code { get; }
public string Title { get; set; }
public int RecommendedPlayers
public Game(string code, string title, int recommendedPlayers)
public string GetDescription()
```

### GameShelf.cs

```csharp
public class GameShelf
public string Name { get; }
public int Count { get; }
public GameShelf(string name)
public bool AddGame(Game? game)
public Game? FindByCode(string code)
public bool RemoveByCode(string code)
public string GetReport()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

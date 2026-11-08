# 4. Diagnose a Wrong Progress Report

Maak eerst de oefening uit hoofdstuk 2 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter02/Ch02ProgressReport`):

```powershell
dotnet new console --name Ch02ProgressReport --output Ch02ProgressReport --framework net10.0
dotnet sln Ch02ProgressReport.sln add Ch02ProgressReport/Ch02ProgressReport.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch02ProgressReport` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch02ProgressReport
dotnet test Ch02ProgressReport.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

Gebruik voor deze oefening een expliciete `public static class Program` met `public static void Main()` en de onderstaande `public static` rekenmethoden. Losse methoden bij top-level statements zijn lokaal en niet bereikbaar vanuit het testproject. Dit gaat alleen over de structuur; werk de berekeningen zelf uit. Ongeldige invoer moet de aanroeper vóór de berekening weigeren, zoals de cursus vraagt. De rekentests roepen daarom alleen geldige invoer aan.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Program.cs

```csharp
public static class Program
public static decimal CalculateCompletionPercentage(int completed, int planned)
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

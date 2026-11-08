# 2. Museum Admission

Maak eerst de oefening uit hoofdstuk 2 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter02/Ch02MuseumAdmission`):

```powershell
dotnet new console --name Ch02MuseumAdmission --output Ch02MuseumAdmission --framework net10.0
dotnet sln Ch02MuseumAdmission.sln add Ch02MuseumAdmission/Ch02MuseumAdmission.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch02MuseumAdmission` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch02MuseumAdmission
dotnet test Ch02MuseumAdmission.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

Gebruik voor deze oefening een expliciete `public static class Program` met `public static void Main()` en de onderstaande `public static` rekenmethoden. Losse methoden bij top-level statements zijn lokaal en niet bereikbaar vanuit het testproject. Dit gaat alleen over de structuur; werk de berekeningen zelf uit. Ongeldige invoer moet de aanroeper vóór de berekening weigeren, zoals de cursus vraagt. De rekentests roepen daarom alleen geldige invoer aan.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Program.cs

```csharp
public static class Program
public static decimal GetAdmissionPrice(int age)
public static decimal CalculateVisitPrice(int age, bool guidedTour)
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

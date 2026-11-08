# 4. Printer Planning: Keep Your LINQ Skills

Maak eerst de oefening uit hoofdstuk 6 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter06/Ch06PrinterPlanning`):

```powershell
dotnet new console --name Ch06PrinterPlanning --output Ch06PrinterPlanning --framework net10.0
dotnet sln Ch06PrinterPlanning.sln add Ch06PrinterPlanning/Ch06PrinterPlanning.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch06PrinterPlanning` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch06PrinterPlanning
dotnet test Ch06PrinterPlanning.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Printer.cs

```csharp
public class Printer
public string Code { get; }
public decimal CostPerPage { get; }
public Printer(string code, decimal costPerPage)
public decimal GetPrintCost(int pages)
```

### PhotoPrinter.cs

```csharp
public class PhotoPrinter : Printer
public int MaxWidth { get; }
public PhotoPrinter(string code, decimal costPerPage, int maxWidth)
public bool CanPrintWidth(int width)
```

### PrintShop.cs

```csharp
public class PrintShop
public int Count { get; }
public bool AddPrinter(PhotoPrinter? printer)
public List<string> GetSuitableCodes(int width)
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

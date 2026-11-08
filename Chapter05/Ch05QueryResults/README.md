# 4. Equipment Availability: A New List Is Not New Objects

Maak eerst de oefening uit hoofdstuk 5 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter05/Ch05QueryResults`):

```powershell
dotnet new console --name Ch05QueryResults --output Ch05QueryResults --framework net10.0
dotnet sln Ch05QueryResults.sln add Ch05QueryResults/Ch05QueryResults.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch05QueryResults` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch05QueryResults
dotnet test Ch05QueryResults.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Equipment.cs

```csharp
public class Equipment
public string Code { get; }
public string Name { get; set; }
public bool IsAvailable { get; set; }
public decimal DailyPrice
public Equipment(string code, string name, decimal dailyPrice, bool isAvailable)
```

### EquipmentInventory.cs

```csharp
public class EquipmentInventory
public int Count { get; }
public bool AddItem(Equipment? item)
public Equipment? FindByCode(string code)
public List<Equipment> GetAvailable(decimal maximumPrice)
public List<string> GetAvailableNames(decimal maximumPrice)
public List<string> GetCodes()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

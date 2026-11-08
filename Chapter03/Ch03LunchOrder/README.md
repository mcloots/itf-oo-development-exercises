# 2. A Lunch Order That Owns Its Total

Maak eerst de oefening uit hoofdstuk 3 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter03/Ch03LunchOrder`):

```powershell
dotnet new console --name Ch03LunchOrder --output Ch03LunchOrder --framework net10.0
dotnet sln Ch03LunchOrder.sln add Ch03LunchOrder/Ch03LunchOrder.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch03LunchOrder` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch03LunchOrder
dotnet test Ch03LunchOrder.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### LunchOrder.cs

```csharp
public class LunchOrder
public LunchOrder(string sandwichName, decimal unitPrice, int quantity)
public string GetSandwichName()
public decimal GetUnitPrice()
public int GetQuantity()
public void SetQuantity(int value)
public decimal CalculateTotal()
public string GetDescription()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

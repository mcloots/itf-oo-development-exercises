# 3. Stock Item: Keep the Last Valid Quantity

Maak eerst de oefening uit hoofdstuk 7 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter07/Ch07Stock`):

```powershell
dotnet new console --name Ch07Stock --output Ch07Stock --framework net10.0
dotnet sln Ch07Stock.sln add Ch07Stock/Ch07Stock.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch07Stock` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch07Stock
dotnet test Ch07Stock.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### StockItem.cs

```csharp
public class StockItem
public string Code { get; }
public int Quantity { get; private set; }
public StockItem(string code, int quantity)
public void Take(int amount)
```

### StockOperationException.cs

```csharp
public class StockOperationException : Exception
public StockOperationException(string message) : base(message)
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

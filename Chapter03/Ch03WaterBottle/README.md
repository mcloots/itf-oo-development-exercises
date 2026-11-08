# 1. A Refillable Water Bottle

Maak eerst de oefening uit hoofdstuk 3 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter03/Ch03WaterBottle`):

```powershell
dotnet new console --name Ch03WaterBottle --output Ch03WaterBottle --framework net10.0
dotnet sln Ch03WaterBottle.sln add Ch03WaterBottle/Ch03WaterBottle.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch03WaterBottle` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch03WaterBottle
dotnet test Ch03WaterBottle.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### WaterBottle.cs

```csharp
public class WaterBottle
public WaterBottle(string label, int capacity)
public string GetLabel()
public void SetLabel(string value)
public int GetCapacity()
public int GetContents()
public bool Fill(int amount)
public bool Drink(int amount)
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

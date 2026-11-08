# 2. Delivery Planning: Count, Any, and the Next Match

Maak eerst de oefening uit hoofdstuk 5 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter05/Ch05DeliveryQueries`):

```powershell
dotnet new console --name Ch05DeliveryQueries --output Ch05DeliveryQueries --framework net10.0
dotnet sln Ch05DeliveryQueries.sln add Ch05DeliveryQueries/Ch05DeliveryQueries.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch05DeliveryQueries` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch05DeliveryQueries
dotnet test Ch05DeliveryQueries.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Delivery.cs

```csharp
public class Delivery
public string Code { get; }
public string Destination { get; set; }
public bool IsDispatched { get; set; }
public decimal DistanceKm
public Delivery(string code, string destination, decimal distanceKm, bool isDispatched)
```

### DeliveryPlanner.cs

```csharp
public class DeliveryPlanner
public int Count { get; }
public bool AddDelivery(Delivery? delivery)
public Delivery? FindByCode(string code)
public int CountPendingWithin(decimal maximumKm)
public bool HasPendingBeyond(decimal minimumKm)
public Delivery? GetNextPending()
public List<string> GetPendingDestinationsWithin(decimal maximumKm)
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

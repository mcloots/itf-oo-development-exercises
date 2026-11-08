# 1. Parcel Prices: One Shared Calculation

Maak eerst de oefening uit hoofdstuk 6 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter06/Ch06Parcels`):

```powershell
dotnet new console --name Ch06Parcels --output Ch06Parcels --framework net10.0
dotnet sln Ch06Parcels.sln add Ch06Parcels/Ch06Parcels.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch06Parcels` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch06Parcels
dotnet test Ch06Parcels.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Parcel.cs

```csharp
public class Parcel
public string Code { get; }
public decimal Weight { get; }
public decimal RatePerKg
public Parcel(string code, decimal weight)
public decimal GetShippingCost()
```

### ExpressParcel.cs

```csharp
public class ExpressParcel : Parcel
public string TrackingCode { get; }
public ExpressParcel(string code, decimal weight, string trackingCode)
public string GetTrackingDescription()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

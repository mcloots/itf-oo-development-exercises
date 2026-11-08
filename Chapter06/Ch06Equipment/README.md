# 2. Rental Equipment: Two Children

Maak eerst de oefening uit hoofdstuk 6 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter06/Ch06Equipment`):

```powershell
dotnet new console --name Ch06Equipment --output Ch06Equipment --framework net10.0
dotnet sln Ch06Equipment.sln add Ch06Equipment/Ch06Equipment.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch06Equipment` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch06Equipment
dotnet test Ch06Equipment.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Equipment.cs

```csharp
public class Equipment
public string Code { get; }
public decimal DailyRate { get; protected set; }
public Equipment(string code)
public decimal GetRentalCost(int days)
public virtual string GetDescription()
```

### Camera.cs

```csharp
public class Camera : Equipment
public int Megapixels { get; }
public Camera(string code, int megapixels) : base(code)
public bool CanPrintPoster()
public override string GetDescription()
```

### Projector.cs

```csharp
public class Projector : Equipment
public int Lumens { get; }
public Projector(string code, int lumens) : base(code)
public bool IsSuitableForHall()
public override string GetDescription()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

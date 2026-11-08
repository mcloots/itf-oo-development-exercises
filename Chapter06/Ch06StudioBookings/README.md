# 3. Studio Bookings: Inheritance and Association

Maak eerst de oefening uit hoofdstuk 6 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter06/Ch06StudioBookings`):

```powershell
dotnet new console --name Ch06StudioBookings --output Ch06StudioBookings --framework net10.0
dotnet sln Ch06StudioBookings.sln add Ch06StudioBookings/Ch06StudioBookings.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch06StudioBookings` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch06StudioBookings
dotnet test Ch06StudioBookings.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Room.cs

```csharp
public class Room
public string Name { get; }
public decimal HourlyRate { get; }
public Room(string name, decimal hourlyRate)
public decimal GetCost(int hours)
```

### Studio.cs

```csharp
public class Studio : Room
public bool HasPiano { get; }
public Studio(string name, decimal hourlyRate, bool hasPiano)
public string GetEquipmentDescription()
```

### StudioBooking.cs

```csharp
public class StudioBooking
public Studio Studio { get; }
public int Hours { get; }
public StudioBooking(Studio studio, int hours)
public decimal GetTotalCost()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

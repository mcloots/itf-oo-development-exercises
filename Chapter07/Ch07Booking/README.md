# 2. Seat Booking: Protect Capacity

Maak eerst de oefening uit hoofdstuk 7 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter07/Ch07Booking`):

```powershell
dotnet new console --name Ch07Booking --output Ch07Booking --framework net10.0
dotnet sln Ch07Booking.sln add Ch07Booking/Ch07Booking.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch07Booking` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch07Booking
dotnet test Ch07Booking.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### SeatBooking.cs

```csharp
public class SeatBooking
public int Capacity { get; }
public int Reserved { get; private set; }
public SeatBooking(int capacity)
public void Reserve(int seats)
```

### BookingOperationException.cs

```csharp
public class BookingOperationException : Exception
public BookingOperationException(string message) : base(message)
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

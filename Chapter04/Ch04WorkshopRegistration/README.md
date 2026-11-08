# 4. Workshop Registration: Protect a Collection's Rules

Maak eerst de oefening uit hoofdstuk 4 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter04/Ch04WorkshopRegistration`):

```powershell
dotnet new console --name Ch04WorkshopRegistration --output Ch04WorkshopRegistration --framework net10.0
dotnet sln Ch04WorkshopRegistration.sln add Ch04WorkshopRegistration/Ch04WorkshopRegistration.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch04WorkshopRegistration` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch04WorkshopRegistration
dotnet test Ch04WorkshopRegistration.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Participant.cs

```csharp
public class Participant
public string Id { get; }
public string Name { get; set; }
public Participant(string id, string name)
public string GetDescription()
```

### Workshop.cs

```csharp
public class Workshop
public string Code { get; }
public string Title { get; set; }
public int ParticipantCount { get; }
public int Capacity
public Workshop(string code, string title, int capacity)
public bool Register(Participant? participant)
public Participant? FindParticipant(string id)
public bool Cancel(string id)
public string GetReport()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

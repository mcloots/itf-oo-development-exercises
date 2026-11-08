# 1. Room Temperatures: Properties and a Fixed Array

Maak eerst de oefening uit hoofdstuk 4 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter04/Ch04RoomTemperatures`):

```powershell
dotnet new console --name Ch04RoomTemperatures --output Ch04RoomTemperatures --framework net10.0
dotnet sln Ch04RoomTemperatures.sln add Ch04RoomTemperatures/Ch04RoomTemperatures.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch04RoomTemperatures` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch04RoomTemperatures
dotnet test Ch04RoomTemperatures.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### RoomThermostat.cs

```csharp
public class RoomThermostat
public string RoomCode { get; }
public string Label { get; set; }
public decimal TargetTemperature
public RoomThermostat(string roomCode, string label, decimal targetTemperature)
public string GetDescription()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

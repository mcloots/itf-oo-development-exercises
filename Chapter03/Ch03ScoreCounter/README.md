# 4. A Score Counter and an Unexpected Shared Change

Maak eerst de oefening uit hoofdstuk 3 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter03/Ch03ScoreCounter`):

```powershell
dotnet new console --name Ch03ScoreCounter --output Ch03ScoreCounter --framework net10.0
dotnet sln Ch03ScoreCounter.sln add Ch03ScoreCounter/Ch03ScoreCounter.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch03ScoreCounter` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch03ScoreCounter
dotnet test Ch03ScoreCounter.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### ScoreCounter.cs

```csharp
public class ScoreCounter
public ScoreCounter(string teamName)
public string GetTeamName()
public int GetScore()
public void SetScore(int value)
public void AddPoints(int points)
public void Reset()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

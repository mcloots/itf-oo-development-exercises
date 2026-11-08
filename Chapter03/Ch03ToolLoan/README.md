# 3. A Tool Loan with Allowed Actions

Maak eerst de oefening uit hoofdstuk 3 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter03/Ch03ToolLoan`):

```powershell
dotnet new console --name Ch03ToolLoan --output Ch03ToolLoan --framework net10.0
dotnet sln Ch03ToolLoan.sln add Ch03ToolLoan/Ch03ToolLoan.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch03ToolLoan` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch03ToolLoan
dotnet test Ch03ToolLoan.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### ToolLoan.cs

```csharp
public class ToolLoan
public ToolLoan(string toolCode)
public string GetToolCode()
public string GetBorrower()
public bool GetIsBorrowed()
public bool Borrow(string borrower)
public bool ReturnTool()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

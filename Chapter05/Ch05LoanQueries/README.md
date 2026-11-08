# 3. Tool Loans: Query Through an Association

Maak eerst de oefening uit hoofdstuk 5 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter05/Ch05LoanQueries`):

```powershell
dotnet new console --name Ch05LoanQueries --output Ch05LoanQueries --framework net10.0
dotnet sln Ch05LoanQueries.sln add Ch05LoanQueries/Ch05LoanQueries.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch05LoanQueries` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch05LoanQueries
dotnet test Ch05LoanQueries.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Member.cs

```csharp
public class Member
public string Id { get; }
public string Name { get; set; }
public Member(string id, string name)
```

### ToolLoan.cs

```csharp
public class ToolLoan
public string Code { get; }
public Member Member { get; }
public string ToolName { get; set; }
public int DaysUntilDue { get; set; }
public bool IsReturned { get; set; }
public ToolLoan(string code, Member member, string toolName, int daysUntilDue, bool isReturned)
```

### LoanDesk.cs

```csharp
public class LoanDesk
public int Count { get; }
public bool AddLoan(ToolLoan? loan)
public ToolLoan? FindByCode(string code)
public List<string> GetOverdueReport()
public int CountOverdue()
public bool HasOverdueForMember(string memberId)
public ToolLoan? FindMostOverdueForMember(string memberId)
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

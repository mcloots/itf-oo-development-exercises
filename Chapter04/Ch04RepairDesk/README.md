# 3. A Repair Desk: Follow Associations and Calculate Totals

Maak eerst de oefening uit hoofdstuk 4 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter04/Ch04RepairDesk`):

```powershell
dotnet new console --name Ch04RepairDesk --output Ch04RepairDesk --framework net10.0
dotnet sln Ch04RepairDesk.sln add Ch04RepairDesk/Ch04RepairDesk.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch04RepairDesk` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch04RepairDesk
dotnet test Ch04RepairDesk.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### Customer.cs

```csharp
public class Customer
public string Id { get; }
public string Name { get; set; }
public Customer(string id, string name)
```

### RepairJob.cs

```csharp
public class RepairJob
public string Code { get; }
public Customer Customer { get; }
public bool IsCompleted { get; private set; }
public decimal QuotedCost
public RepairJob(string code, Customer customer, decimal quotedCost)
public void Complete()
public string GetDescription()
```

### RepairDesk.cs

```csharp
public class RepairDesk
public int Count { get; }
public bool AddJob(RepairJob? job)
public RepairJob? FindByCode(string code)
public bool RemoveByCode(string code)
public decimal GetOpenTotal()
public string GetReport()
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

# 1. Bank Account: Refuse a Withdrawal

Maak eerst de oefening uit hoofdstuk 7 van de cursus. De cursus blijft de opdracht; hieronder staat hoe je jouw eigen project koppelt aan de bestaande tests.

Voer deze opdrachten uit **vanuit deze map** (`Chapter07/Ch07Account`):

```powershell
dotnet new console --name Ch07Account --output Ch07Account --framework net10.0
dotnet sln Ch07Account.sln add Ch07Account/Ch07Account.csproj
```

Implementeer de oefening in je nieuwe project, met namespace `Ch07Account` en één bestand per klasse. Maak de geteste klassen en methoden `public`. Het testproject verwijst al naar het juiste pad. Voeg geen testbestanden toe aan je consoleproject.

```powershell
dotnet run --project Ch07Account
dotnet test Ch07Account.sln
```

Zolang het project of een gevraagd onderdeel ontbreekt, krijg je een bouwfout. Zodra alles compileert, tonen de tests welke gecontroleerde gedragingen slagen of falen. Verander de tests niet om een fout te verbergen.

## Verwachte publieke onderdelen

Dit overzicht toont namen en signatures, geen uitwerking. Gebruik de cursus voor validatieregels en toegangsrechten.

### BankAccount.cs

```csharp
public class BankAccount
public decimal Balance { get; private set; }
public BankAccount(decimal openingBalance)
public void Withdraw(decimal amount)
```

## Zelf controleren

Vergelijk ook je console-uitvoer met de cursus. UML, verklaringen, gekozen constructies en de scheiding tussen console en domeinklassen blijven onderdeel van de oefening; groene tests bewijzen die niet.

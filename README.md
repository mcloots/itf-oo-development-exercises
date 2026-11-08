# OO Development — oefeningen hoofdstuk 2–7

Deze startrepo bevat **23 solutions met elk een xUnit-testproject**. Je maakt elk consoleproject zelf en schrijft zelf de oplossing. Vereist: .NET SDK 10 en toegang tot NuGet bij de eerste restore.

## Beginnen

1. Open de map van de oefening waarmee je bezig bent, bijvoorbeeld `Chapter02/Ch02ParcelDelivery`.
2. Volg de README in die map om zelf het consoleproject te maken en aan de bestaande solution toe te voegen.
3. Maak de oefening uit de cursus. Gebruik de projectnaam, namespace en publieke onderdelen uit de lokale README.
4. Voer je consoleprogramma uit en vergelijk het resultaat met de cursus.
5. Voer de tests uit. Verbeter je eigen code en herhaal.

Voorbeeld, vanuit de hoofdmap van deze repo:

```powershell
cd Chapter02/Ch02ParcelDelivery
dotnet new console --name Ch02ParcelDelivery --output Ch02ParcelDelivery --framework net10.0
dotnet sln Ch02ParcelDelivery.sln add Ch02ParcelDelivery/Ch02ParcelDelivery.csproj
# Schrijf nu zelf je oplossing in het nieuwe consoleproject.
dotnet run --project Ch02ParcelDelivery
dotnet test Ch02ParcelDelivery.sln
```

De map ziet er daarna zo uit:

```text
Ch02ParcelDelivery/
  Ch02ParcelDelivery.sln
  README.md
  Ch02ParcelDelivery.Tests/       # al aanwezig
  Ch02ParcelDelivery/             # maak je zelf
    Ch02ParcelDelivery.csproj
    Program.cs
```

Open in Visual Studio de bestaande `.sln`. In VS Code open je de hele oefenmap, zodat de solution en beide projecten zichtbaar zijn. De projectreferentie van het testproject staat al klaar.

## Bouwfout of falende test?

- **Project ontbreekt:** maak het consoleproject op het pad uit de lokale README. De startrepo bevat bewust nog geen studentprojecten.
- **Type of methode ontbreekt / niet toegankelijk:** implementeer de gevraagde publieke onderdelen met de juiste namespace. Hoofdstuk 2 gebruikt een expliciete publieke `Program`-klasse met publieke statische methoden.
- **Een test faalt:** het project compileert, maar een gecontroleerd resultaat klopt nog niet. Lees de testnaam en het verwachte en werkelijke resultaat.
- **Alles groen:** de gecontroleerde gedragingen slagen. Controleer nog steeds je UML, consoleprogramma, verklaringen en de gevraagde aanpak (bijvoorbeeld loops, LINQ of overerving).

Verander geen tests om ze groen te krijgen. Geldige alternatieve implementaties kunnen dezelfde tests doorstaan. De tests schrijven geen private veldnamen of exacte console-opmaak voor. Sommige gevraagde domeinbeschrijvingen worden wel inhoudelijk gecontroleerd. Bij hoofdstuk 2 testen we de rekenmethoden met geldige invoer; controle van ongeldige invoer in het consoleprogramma blijft een handmatige check.

## Meerdere gemaakte oefeningen controleren

Vanuit de hoofdmap, in PowerShell:

```powershell
./Test-Exercises.ps1
./Test-Exercises.ps1 -Chapter 3
./Test-Exercises.ps1 -Exercise Ch07Account
```

De eerste twee opdrachten slaan nog niet aangemaakte projecten over en melden die afzonderlijk. Een expliciet gekozen oefening zonder project geeft een fout. Gebruik de losse `dotnet test`-opdracht in de oefenmap als je liever zonder script werkt.

## Oefeningen

| Hoofdstuk | Map / projectnaam | Oefening |
| :--- | :--- | :--- |
| 2 | [Ch02ParcelDelivery](Chapter02/Ch02ParcelDelivery/) | Parcel Delivery Quote |
| 2 | [Ch02MuseumAdmission](Chapter02/Ch02MuseumAdmission/) | Museum Admission |
| 2 | [Ch02WaterBill](Chapter02/Ch02WaterBill/) | Water Use Estimate |
| 2 | [Ch02ProgressReport](Chapter02/Ch02ProgressReport/) | Diagnose a Wrong Progress Report |
| 3 | [Ch03WaterBottle](Chapter03/Ch03WaterBottle/) | A Refillable Water Bottle |
| 3 | [Ch03LunchOrder](Chapter03/Ch03LunchOrder/) | A Lunch Order That Owns Its Total |
| 3 | [Ch03ToolLoan](Chapter03/Ch03ToolLoan/) | A Tool Loan with Allowed Actions |
| 3 | [Ch03ScoreCounter](Chapter03/Ch03ScoreCounter/) | A Score Counter and an Unexpected Shared Change |
| 4 | [Ch04RoomTemperatures](Chapter04/Ch04RoomTemperatures/) | Room Temperatures: Properties and a Fixed Array |
| 4 | [Ch04GameShelf](Chapter04/Ch04GameShelf/) | A Board Game Shelf: Add, Find, and Remove |
| 4 | [Ch04RepairDesk](Chapter04/Ch04RepairDesk/) | A Repair Desk: Follow Associations and Calculate Totals |
| 4 | [Ch04WorkshopRegistration](Chapter04/Ch04WorkshopRegistration/) | Workshop Registration: Protect a Collection's Rules |
| 5 | [Ch05LibraryQueries](Chapter05/Ch05LibraryQueries/) | Library Recommendations: Filter, Sort, and Project |
| 5 | [Ch05DeliveryQueries](Chapter05/Ch05DeliveryQueries/) | Delivery Planning: Count, Any, and the Next Match |
| 5 | [Ch05LoanQueries](Chapter05/Ch05LoanQueries/) | Tool Loans: Query Through an Association |
| 5 | [Ch05QueryResults](Chapter05/Ch05QueryResults/) | Equipment Availability: A New List Is Not New Objects |
| 6 | [Ch06Parcels](Chapter06/Ch06Parcels/) | Parcel Prices: One Shared Calculation |
| 6 | [Ch06Equipment](Chapter06/Ch06Equipment/) | Rental Equipment: Two Children |
| 6 | [Ch06StudioBookings](Chapter06/Ch06StudioBookings/) | Studio Bookings: Inheritance and Association |
| 6 | [Ch06PrinterPlanning](Chapter06/Ch06PrinterPlanning/) | Printer Planning: Keep Your LINQ Skills |
| 7 | [Ch07Account](Chapter07/Ch07Account/) | Bank Account: Refuse a Withdrawal |
| 7 | [Ch07Booking](Chapter07/Ch07Booking/) | Seat Booking: Protect Capacity |
| 7 | [Ch07Stock](Chapter07/Ch07Stock/) | Stock Item: Keep the Last Valid Quantity |

## Voor de docent

Zie [TEACHER.md](TEACHER.md) voor het gebruik als startrepo per student en de grenzen van de automatische controles.

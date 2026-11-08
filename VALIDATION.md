# Validatie — 7 november 2026

- .NET SDK 10.0.401, Windows.
- Alle 23 testprojecten gebouwd en uitgevoerd tegen de bestaande cursusuitwerkingen in een aparte tijdelijke kopie.
- **120 testgevallen geslaagd, 0 gefaald, 0 overgeslagen.**
- De cursusuitwerkingen zitten niet in deze repo.
- Negatieve controle: de decimale deling in Ch02ProgressReport tijdelijk vervangen door integerdeling. Drie van vijf tests faalden zoals verwacht. Na herstel slaagden alle vijf opnieuw.
- Project toevoegen aan de bestaande solution gecontroleerd met `dotnet sln ... add`.
- Een ontbrekend studentproject geeft de bedoelde instructie bij het bouwen.
- PowerShell-script gecontroleerd op nog niet gemaakte oefeningen en een geselecteerde volledig gemaakte oefening; die oefening wordt succesvol getest.

De startrepo zelf bevat nog geen studentprojecten: die moet de student eerst maken en implementeren voordat de tests kunnen bouwen en draaien. Dit resultaat beschrijft de controle van het testmateriaal tegen de cursusuitwerkingen, niet een reeds ingevulde studentrepo.

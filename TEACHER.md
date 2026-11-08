# Gebruik als startrepo

Deze map is een zelfstandige lokale Git-repo, buiten de cursusinhoud in `docs`. De repo bevat geen studentprojecten en geen uitwerkingen. De projectnamen en contracten volgen de 23 standalone oefeningen uit hoofdstuk 2–7; de oudere oefenreeksen, Apex en het vrije eigen project vallen buiten deze repo.

Je kunt deze map later als GitHub template repository publiceren en per student een eigen private repo laten maken. Er is nu niets op GitHub aangemaakt of gepubliceerd. Iedere student begint met dezelfde tests en maakt de consoleprojecten zelf. Maak eventueel één startcommit voordat je de repo verspreidt; er is lokaal nog geen commit gemaakt.

Elke oefening heeft een eigen solution. Daardoor blokkeren ontbrekende klassen in andere oefeningen de huidige oefening niet. In de beginsituatie is een bouwfout bij het testen verwacht: de student moet eerst het project en de gevraagde publieke onderdelen maken. Er staan geen lege implementaties, voorbeeldantwoorden of altijd groene placeholdertests in de repo.

De tests controleren voorbeeldgevallen en aanvullende waarden, grenzen, validatie, toestand na weigering, collectiegedrag, objectidentiteit en polymorfisme waar relevant. De testprojecten gebruiken .NET 10, xUnit 2 en de Visual Studio testadapter. Pakketversies staan vast per project. Eerste restore kan internet vereisen.

Beoordeel UML, verklaringen, de gebruikte lesconcepten, private gegevens en toegang tot setters ook zelf. De tests bewijzen niet dat een student daadwerkelijk LINQ, een vaste array, base-aanroepen of een specifieke lus gebruikt. Hoofdstuk 2 test berekeningen met geldige invoer; weigeringen en uitvoer in Program worden handmatig gecontroleerd. De lokale LINQ-timingexperimenten in Program van hoofdstuk 5 blijven eveneens een handmatige controle.

Publieke tests zijn nuttig voor feedback, maar studenten kunnen ze in hun eigen repo aanpassen. Gebruik bij beoordeling een eigen ongewijzigde kopie van de tests. Groene tests zijn geen volledige beoordeling en geen bewijs dat de code zelfstandig is gemaakt.

De tests zijn vóór oplevering in een aparte tijdelijke kopie uitgevoerd met de bestaande cursusuitwerkingen. Die uitwerkingen worden niet meegeleverd in de studentrepo. Zie VALIDATION.md voor het resultaat van die controle.

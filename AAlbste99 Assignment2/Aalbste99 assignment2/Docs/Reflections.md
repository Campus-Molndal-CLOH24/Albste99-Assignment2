Namn: [Albin Stenhoff]

# Inlämningsrapport

Information
OBS!!! Ändra absolut inte på rubrikerna i denna fil!!!!

## Inledning

### Hur uppfattade du uppgiften initialt?
Jag  uppfattade uppgiften som utmanade men ändå hanterbar. Det var många olika delar att hålla reda på, särskilt interfacen och fabrikens samspel.
Till en början var det svårt att förstå hur alla klasser och interfaces skulle kopplas ihop, men genom att bryta ner uppgiften och fokusera på en sak i taget blev den mer begriplig.
--- Skriv ovanför och ta inte bort denna raden ---

## Planering och genomförande

### Vilka steg tog du för att lösa uppgiften?
1. Först började jag med att implementera de två klasserna Carimpl och Motorcycleimpl, och såg till att alla nödvändiga metoder från respektive interface var korrekt implenterade.
2. Sedan skapade jag fabrikerna för fordonen,CarFactory och MotorcycleFactory som var ansvariga för att skapa nya objekt baserat på fordonstyp.
3. Jag skapade också en lista av IDriveable objekt som innehöll både bilar och motorcyklar. Detta tillät mig att på ett effektivt sätt iterera genom fordonen och anropa Drive() metoden
utan att behöva känna till den exakta typen av fordon. Detta var en nyckel i att hålla min kod strukturerad och flexibel.
4. Därefter såg jag till att ToString()-metoderna var implenterade så att de kunde skriva ut alla detaljer om fordonen korrekt.
5. För att implementera lastbilar i koden skapade jag TruckFactory och definierade specifika parametrar som lastkapacitet(CargoCapacity). Jag justerade metoden CreateVehicle i fabrikerna
så att det kunde ta fler argument för att stödja dessa nya fordonstyper. På samma sätt implementerade jag motorcyklar genom att lägga till parametrar som EngineType för att hantera motorcykelns specifika motorer.
6. Jag felsökte och hanterade de olika felmeddelandena i koden, som tilll exempel saknade implementationer, problem med curly braces och namespaces.
7. Jag testade programmet löpande för att säkerställa kvalitet och att det fungerade som förväntat.
--- Skriv ovanför och ta inte bort denna raden ---

## Utmaningar och lösningar

### Vilka utmaningar stötte du på under projektet?
En av de största utmaningarna var att förstå hur alla interfaces och klasser skulle kopplas ihop och hur jag skulle implementera fabrikerna på rätt sätt.
Ett annat stort problem var att jag inte ville ändra i Program.cs för att få den förväntade utdata, vilket betydde att jag behövde hitta andra sätt att få den förväntade utskriften
utan att direkt påverka existerande programkoden. 
Jag stötte också på problem med att korrekt anropa Drive() metoden för både bil och motorcykel i program.cs. 
Efter att ha lagt till en loop över min lista av fordon kunde jag få rätt utskrifter.
Att förstå hur man använder interface som IDriveable för att anropa gemensamma metoder hjälpte mig att lösa detta problem.
En specifik utmaning var att säkerställa att rätt parametrar överfördes till mina fabriksmetoder när jag skapade lastbilar och motorcyklar.
Jag var tvungen att justera antalet parametrar som CreateVehicle-metoden tog, och i vissa fall lade jag till nya fält såsom CargoCapacity och EngineType.
En annan utmaning var att undvika upprepning av information när fordonets specifikationer skrevs ut, eftersom vissa värden visades två gånger.
--- Skriv ovanför och ta inte bort denna raden ---

### Hur löste du dessa utmaningar?
Jag löste dem genom att implentera ToString()- metoderna i mina fordonklasser.
Detta gjorde att jag kunde styra hur fordonen skrevs ut utan att behöva äändra i programmet. Jag använde också mycket tid på att felsöka och arbeta med detaljer som curly braces
och fel i namespaces, vilket hjälpte mig att bättre förstå hur C# kod organiseras och fungerar.
Vid vissa tillfällen när jag stötte på problem med implementation eller när jag behövde få klarhet kring specifika programmeringsbegrepp,
använde jag ChatGPT som verktyg för att komma vidare. ChatGPT hjälpte mig att förstå vissa koncept snabbare och gav mig ideer för att felsöka effektivt.
Trots det var det viktigt för mig att jag i huvudsak  löste uppgifterna själv, för att bygga en djupare förståelse.
--- Skriv ovanför och ta inte bort denna raden ---

### Beskriv några implementeringsval du gjort?
Jag valde att implentera ToString() för att få ut den fullständiga fordonsspecifikationen.
Jag implementerade Drive() i både bil och motorcykelklasserna, vilket gjorde att jag kunde skriva en enhetlig metod för att köra alla fordon utan att bry mig om deras specifika implementering.
Fabrikerna spelade en stor roll i att skapa fordon med rätt egenskaper utan att direkt skapa instanser av CarImpl eller MotorcycleImpl i huvudprogrammet.
Jag använde en struktur med fabriker flr att skapa fordonen, vilket var ett bra sätt att kapsla in objektens skapande och hålla koden organiserad.
Jag implenterade properties som encapsulation-principer i C#, vilket gav bra kontroll över fordonens egenskaper.
--- Skriv ovanför och ta inte bort denna raden ---

## Reflektion och utvärdering

### Vad lärde du dig genom att genomföra projektet?
Jag lärde mig mycket om hur man struktuerar objektorienterad kod i C# och hur interfaces och klasser samverkar.
Jag förstod också hur viktigt det är att följa principer för encapsulation och att använda fabriker för att hantera komplexa objekt. Dessutom fick jag erfarenhet av att felsöka och
hantera vanliga C# felmeddelanden, vilket har stärkt min förståelse för språket.
Att använda interfaces som IDriveable och fabriksmönster hjälpte mig att hålla min kod välorganiserad och lätt att förstå. Genom att abstrahera bort den faktiska skapandet av objekt
med hjälp av fabriker kunde jag fokusera mer på logiken, vilket gör koden mer skalbar och enkel att ändra. 
Detta är något jag kommer att använda i framtida projekt när jag hanterar komplexa strukturer.
--- Skriv ovanför och ta inte bort denna raden ---

### Vilka möjligheter ser du för framtida projekt baserat på denna erfarenhet?
Med den erfarenhet jag nu har kan jag hantera mer komplexa projekt som involverar flera olika typer av objekt och struktuerer som interfaces och fabriker.
Jag känner mig också mer säker på att arbeta med objektorienterad programmering i allmänhett och ser fram emot att utveckla mer avanceradef lösningar i framtida projekt.
Den här erfarenheten har gett mig en bättre förståelse för hur man kan designa program för att vara flexibla och skalbara.
Jag planerar att tillämpa dessa designprinciper, som användningen av interfaces och fabriksmönster,
i framtida projekt för att underlätta hanteringen av fler typer av objekt och deras specifika beteenden.
I framtida projekt skulle jag se till att organisera mina fabriksmetoder bättre för att hantera fler fordonstyper utan att behöva ändra för mycket i grundstrukturen.
Jag har lärt mig vikten av att hantera specifika egenskaper som tillhör olika fordonstyper, som lastkapacitet för lastbilar och motortyp för motorcyklar,
och skulle överväga att använda arv och polymorfism för att undvika upprepningar i kod.
--- Skriv ovanför och ta inte bort denna raden ---
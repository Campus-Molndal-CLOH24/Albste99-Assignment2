Namn: [Albin Stenhoff]

# Inl�mningsrapport

Information
OBS!!! �ndra absolut inte p� rubrikerna i denna fil!!!!

## Inledning

### Hur uppfattade du uppgiften initialt?
Jag  uppfattade uppgiften som utmanade men �nd� hanterbar. Det var m�nga olika delar att h�lla reda p�, s�rskilt interfacen och fabrikens samspel.
Till en b�rjan var det sv�rt att f�rst� hur alla klasser och interfaces skulle kopplas ihop, men genom att bryta ner uppgiften och fokusera p� en sak i taget blev den mer begriplig.
--- Skriv ovanf�r och ta inte bort denna raden ---

## Planering och genomf�rande

### Vilka steg tog du f�r att l�sa uppgiften?
1. F�rst b�rjade jag med att implementera de tv� klasserna Carimpl och Motorcycleimpl, och s�g till att alla n�dv�ndiga metoder fr�n respektive interface var korrekt implenterade.
2. Sedan skapade jag fabrikerna f�r fordonen,CarFactory och MotorcycleFactory som var ansvariga f�r att skapa nya objekt baserat p� fordonstyp.
3. Jag skapade ocks� en lista av IDriveable objekt som inneh�ll b�de bilar och motorcyklar. Detta till�t mig att p� ett effektivt s�tt iterera genom fordonen och anropa Drive() metoden
utan att beh�va k�nna till den exakta typen av fordon. Detta var en nyckel i att h�lla min kod strukturerad och flexibel.
4. D�refter s�g jag till att ToString()-metoderna var implenterade s� att de kunde skriva ut alla detaljer om fordonen korrekt.
5. F�r att implementera lastbilar i koden skapade jag TruckFactory och definierade specifika parametrar som lastkapacitet(CargoCapacity). Jag justerade metoden CreateVehicle i fabrikerna
s� att det kunde ta fler argument f�r att st�dja dessa nya fordonstyper. P� samma s�tt implementerade jag motorcyklar genom att l�gga till parametrar som EngineType f�r att hantera motorcykelns specifika motorer.
6. Jag fels�kte och hanterade de olika felmeddelandena i koden, som tilll exempel saknade implementationer, problem med curly braces och namespaces.
7. Jag testade programmet l�pande f�r att s�kerst�lla kvalitet och att det fungerade som f�rv�ntat.
--- Skriv ovanf�r och ta inte bort denna raden ---

## Utmaningar och l�sningar

### Vilka utmaningar st�tte du p� under projektet?
En av de st�rsta utmaningarna var att f�rst� hur alla interfaces och klasser skulle kopplas ihop och hur jag skulle implementera fabrikerna p� r�tt s�tt.
Ett annat stort problem var att jag inte ville �ndra i Program.cs f�r att f� den f�rv�ntade utdata, vilket betydde att jag beh�vde hitta andra s�tt att f� den f�rv�ntade utskriften
utan att direkt p�verka existerande programkoden. 
Jag st�tte ocks� p� problem med att korrekt anropa Drive() metoden f�r b�de bil och motorcykel i program.cs. 
Efter att ha lagt till en loop �ver min lista av fordon kunde jag f� r�tt utskrifter.
Att f�rst� hur man anv�nder interface som IDriveable f�r att anropa gemensamma metoder hj�lpte mig att l�sa detta problem.
En specifik utmaning var att s�kerst�lla att r�tt parametrar �verf�rdes till mina fabriksmetoder n�r jag skapade lastbilar och motorcyklar.
Jag var tvungen att justera antalet parametrar som CreateVehicle-metoden tog, och i vissa fall lade jag till nya f�lt s�som CargoCapacity och EngineType.
En annan utmaning var att undvika upprepning av information n�r fordonets specifikationer skrevs ut, eftersom vissa v�rden visades tv� g�nger.
--- Skriv ovanf�r och ta inte bort denna raden ---

### Hur l�ste du dessa utmaningar?
Jag l�ste dem genom att implentera ToString()- metoderna i mina fordonklasser.
Detta gjorde att jag kunde styra hur fordonen skrevs ut utan att beh�va ��ndra i programmet. Jag anv�nde ocks� mycket tid p� att fels�ka och arbeta med detaljer som curly braces
och fel i namespaces, vilket hj�lpte mig att b�ttre f�rst� hur C# kod organiseras och fungerar.
Vid vissa tillf�llen n�r jag st�tte p� problem med implementation eller n�r jag beh�vde f� klarhet kring specifika programmeringsbegrepp,
anv�nde jag ChatGPT som verktyg f�r att komma vidare. ChatGPT hj�lpte mig att f�rst� vissa koncept snabbare och gav mig ideer f�r att fels�ka effektivt.
Trots det var det viktigt f�r mig att jag i huvudsak  l�ste uppgifterna sj�lv, f�r att bygga en djupare f�rst�else.
--- Skriv ovanf�r och ta inte bort denna raden ---

### Beskriv n�gra implementeringsval du gjort?
Jag valde att implentera ToString() f�r att f� ut den fullst�ndiga fordonsspecifikationen.
Jag implementerade Drive() i b�de bil och motorcykelklasserna, vilket gjorde att jag kunde skriva en enhetlig metod f�r att k�ra alla fordon utan att bry mig om deras specifika implementering.
Fabrikerna spelade en stor roll i att skapa fordon med r�tt egenskaper utan att direkt skapa instanser av CarImpl eller MotorcycleImpl i huvudprogrammet.
Jag anv�nde en struktur med fabriker flr att skapa fordonen, vilket var ett bra s�tt att kapsla in objektens skapande och h�lla koden organiserad.
Jag implenterade properties som encapsulation-principer i C#, vilket gav bra kontroll �ver fordonens egenskaper.
--- Skriv ovanf�r och ta inte bort denna raden ---

## Reflektion och utv�rdering

### Vad l�rde du dig genom att genomf�ra projektet?
Jag l�rde mig mycket om hur man struktuerar objektorienterad kod i C# och hur interfaces och klasser samverkar.
Jag f�rstod ocks� hur viktigt det �r att f�lja principer f�r encapsulation och att anv�nda fabriker f�r att hantera komplexa objekt. Dessutom fick jag erfarenhet av att fels�ka och
hantera vanliga C# felmeddelanden, vilket har st�rkt min f�rst�else f�r spr�ket.
Att anv�nda interfaces som IDriveable och fabriksm�nster hj�lpte mig att h�lla min kod v�lorganiserad och l�tt att f�rst�. Genom att abstrahera bort den faktiska skapandet av objekt
med hj�lp av fabriker kunde jag fokusera mer p� logiken, vilket g�r koden mer skalbar och enkel att �ndra. 
Detta �r n�got jag kommer att anv�nda i framtida projekt n�r jag hanterar komplexa strukturer.
--- Skriv ovanf�r och ta inte bort denna raden ---

### Vilka m�jligheter ser du f�r framtida projekt baserat p� denna erfarenhet?
Med den erfarenhet jag nu har kan jag hantera mer komplexa projekt som involverar flera olika typer av objekt och struktuerer som interfaces och fabriker.
Jag k�nner mig ocks� mer s�ker p� att arbeta med objektorienterad programmering i allm�nhett och ser fram emot att utveckla mer avanceradef l�sningar i framtida projekt.
Den h�r erfarenheten har gett mig en b�ttre f�rst�else f�r hur man kan designa program f�r att vara flexibla och skalbara.
Jag planerar att till�mpa dessa designprinciper, som anv�ndningen av interfaces och fabriksm�nster,
i framtida projekt f�r att underl�tta hanteringen av fler typer av objekt och deras specifika beteenden.
I framtida projekt skulle jag se till att organisera mina fabriksmetoder b�ttre f�r att hantera fler fordonstyper utan att beh�va �ndra f�r mycket i grundstrukturen.
Jag har l�rt mig vikten av att hantera specifika egenskaper som tillh�r olika fordonstyper, som lastkapacitet f�r lastbilar och motortyp f�r motorcyklar,
och skulle �verv�ga att anv�nda arv och polymorfism f�r att undvika upprepningar i kod.
--- Skriv ovanf�r och ta inte bort denna raden ---
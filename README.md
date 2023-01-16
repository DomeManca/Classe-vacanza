# Classe-Pacchetto Vacanza
Propeties dell classe
string _packageId;
decimal _price;
string _destination;
int _numberOfDays;
bool _includesFlight;
decimal _flightCost;
int _numberOfPeople;

Funzioni:
- Costruttori base con tutte le combinazioni per definire il pacchetto
- void ModifyData(decimal price, string destination, int numberOfDays, bool includesFlight, decimal flightCost) // Modifica i dati del pacchetto
- void Purchase(int numberOfPeople) // Imposta il numero di persone per cui è stato acquistato il pacchetto
- void ChooseFlight(bool includesFlight, decimal flightCost) // Scelta della presenza del volo
- void ChooseNumberOfDays(int numberOfDays) // Scelta del numero dei giorni
- ApplyDiscount(decimal discount) // Applica lo sconto al prezzo del pacchetto
- Vacanza ComparePackages(Vacanza p) // Confronta il prezzo di due pacchetti con la stessa destinazione e numero di giorni

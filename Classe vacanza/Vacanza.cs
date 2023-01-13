using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_vacanza
{
    public class Vacanza
    {
        private string _packageId;
        private decimal _price;
        private string _destination;
        private int _numberOfDays;
        private bool _includesFlight;
        private decimal _flightCost;
        private int _numberOfPeople;

        // Identificativo del pacchetto
        public string PackageId 
        {
            get
            {
                return _packageId;
            }
            private set
            {
                if (value != null)
                    _packageId = value;
                else
                    throw new Exception("Inserire un id valido");
            }
        }

        // Prezzo del pacchetto
        public decimal Price 
        {
            get
            {
                return _price;
            }
            private set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new Exception("Inserire un Prezzo valido");
            }
        }

        // Destinazione del pacchetto
        public string Destination 
        {
            get
            {
                return _destination;
            }
            private set
            {
                if (value != null)
                    _destination = value;
                else
                    throw new Exception("Inserire una destinazione valida");
            }
        }

        // Numero di giorni del pacchetto
        public int NumberOfDays 
        {
            get
            {
                return _numberOfDays;
            }
            private set
            {
                if (value > 0)
                    _numberOfDays = value;
                else
                    throw new Exception("Inserire un numero di giorni valido");
            }
        }

        // Indica se il pacchetto include il volo
        public bool IncludesFlight 
        {
            get
            {
                return _includesFlight;
            }
            private set
            {
                try
                {
                    _includesFlight = value;
                }    
                catch
                {
                    throw new Exception("Inserire un id valido");
                }
                    
            }
        }

        // Costo del volo
        public decimal FlightCost 
        {
            get
            {
                return _flightCost;
            }
            private set
            {
                if (value > 0)
                    _flightCost = value;
                else
                    throw new Exception("Inserire un costo valido");
            }
        }

        // Numero di persone per cui è stato acquistato il pacchetto
        public int NumberOfPeople 
        {
            get
            {
                return _numberOfPeople;
            }
            private set
            {
                if (value > 0)
                    _numberOfPeople = value;
                else
                    throw new Exception("Inserire un numero di persone valido");
            }
        }

        // Imposta i dati del pacchetto
        public Vacanza(string packageId, decimal price, string destination, int numberOfDays, bool includesFlight, decimal flightCost)
        {
            PackageId = packageId;
            Price = price;
            Destination = destination;
            NumberOfDays = numberOfDays;
            IncludesFlight = includesFlight;
            FlightCost = flightCost;
        }
        public Vacanza(string packageId, decimal price, string destination, int numberOfDays) : this(packageId,price,destination,numberOfDays,false,0)
        { }
        public Vacanza(string packageId, decimal price, string destination) : this(packageId, price, destination, 0, false, 0)
        { }
        public Vacanza(string packageId, decimal price) : this(packageId, price, "N/A", 0, false, 0)
        { }
        public Vacanza(string packageId, string destination) : this(packageId, 0, destination, 0, false, 0)
        { }
        public Vacanza() : this("Vuoto", 0, "N/A", 0, false, 0)
        { }

        // Modifica i dati del pacchetto
        public void ModifyData(decimal price, string destination, int numberOfDays, bool includesFlight, decimal flightCost)
        {
            Price = price;
            Destination = destination;
            NumberOfDays = numberOfDays;
            IncludesFlight = includesFlight;
            FlightCost = flightCost;
        }

        // Imposta il numero di persone per cui è stato acquistato il pacchetto
        public void Purchase(int numberOfPeople)
        {
            NumberOfPeople = numberOfPeople;
        }

        // Scelta della presenza del volo
        public void ChooseFlight(bool includesFlight, decimal flightCost)
        {
            IncludesFlight = includesFlight;
            if(IncludesFlight)
                FlightCost = flightCost;
        }

        // Scelta del numero dei giorni
        public void ChooseNumberOfDays(int numberOfDays)
        {
            NumberOfDays = numberOfDays;
        }

        // Applica lo sconto al prezzo del pacchetto
        public void ApplyDiscount(decimal discount)
        {
            if (discount > 0)
                Price -= Price * (discount / 100);
            else
                throw new Exception("Sconto non valido");
        }

        // Confronta il prezzo di due pacchetti con la stessa destinazione e numero di giorni
        public Vacanza ComparePackages(Vacanza p)
        {
            if (this.Destination == p.Destination && this.NumberOfDays == p.NumberOfDays)
            {
                decimal a = this.Price / this.NumberOfDays;
                decimal b = p.Price / p.NumberOfDays;
                if (a > b)
                    return this;
                else
                    return p;
            }
            else
            {
                throw new Exception("I pacchetti non hanno la stessa destinazione o il medesimo numero di giorni");
            }
        }
        
        // Costruttori base
        public override string ToString()
        {
            return this.PackageId + ";" + this.Destination + ";" + this.NumberOfDays + ";" + this.Price + ";" + this.NumberOfPeople;
        }

        public bool Equals(Vacanza p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.PackageId == p.PackageId);
        }

        public Vacanza Clone()
        {
            return new Vacanza(this);
        }

        protected Vacanza(Vacanza other) : this(other.PackageId, other.Price, other.Destination, other.NumberOfDays, other.IncludesFlight,other.FlightCost)
        {
        }
    }
}
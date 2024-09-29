using System;

namespace Vehicles
{
    public class TruckImpl : ITruck, IDriveable
    {
        public string? Brand { get; set; } = string.Empty;  //Märket på lastbilen
        public string? Model { get; set; } = string.Empty;  //Modell på lastbilen
        public int Year { get; set; }  //Tillverkningsår på lastbilen
        public double Mileage { get; set; }  //Antal mil körda på lastbilen
        public int CargoCapacity { get; set; }  //Last kapacitet

        private bool EngineOn = false;  //Egenskap för att hålla koll på om motorn är igång eller inte

        public void StartEngine() //Metod för att starta motorn
        {
            EngineOn = true;
        }
        public void StopEngine() //Metod för att stänga av motorn
        { 
            EngineOn= false;
        }
        public bool IsEngineOn() //Metod för att kontrollera 
        {  
            return EngineOn; 
        }
        public string Drive()  //Metod för att köra lastbilen
        {
            return "Driving the truck";
        }
        public override string ToString()  //Metod för att returnera information om lastbilen
        {
            return $"Truck: {Brand} {Model} ({Year}), Cargo Capacity: {CargoCapacity} kg, Mileage: {Mileage}";
        }
    }

    
    
}

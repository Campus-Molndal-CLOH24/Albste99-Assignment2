using System;

namespace Vehicles
{
    public class TruckImpl : ITruck, IDriveable
    {
        public string? Brand { get; set; } = string.Empty;
        public string? Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public double Mileage { get; set; }
        public int CargoCapacity { get; set; }

        private bool EngineOn = false;

        public void StartEngine()
        {
            EngineOn = true;
        }
        public void StopEngine() 
        { 
            EngineOn= false;
        }
        public bool IsEngineOn() 
        {  
            return EngineOn; 
        }
        public string Drive()
        {
            return "Driving the truck";
        }
        public override string ToString()
        {
            return $"Truck: {Brand} {Model} ({Year}), Cargo Capacity: {CargoCapacity} kg, Mileage: {Mileage}";
        }
    }

    
    
}

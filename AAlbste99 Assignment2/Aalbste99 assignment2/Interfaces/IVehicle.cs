using System;
using Vehicles;

namespace Vehicles
{
    public interface IVehicle  //Interface som definierar grundl�ggande egenskaper och metoder f�r alla fordon
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        double Mileage { get; set; }

        bool IsEngineOn();
        void StartEngine();
        void StopEngine();
    }
}
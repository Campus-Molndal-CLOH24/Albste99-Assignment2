using System;
using Vehicles;

namespace Vehicles
{
    public interface IMotorcycle : IVehicle  //Interface som definierar grundläggande egenskaper och metoder för alla motorcyklar.
    {
        string EngineType { get; set; }
    }
}
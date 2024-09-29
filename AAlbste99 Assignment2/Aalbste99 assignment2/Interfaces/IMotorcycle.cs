using System;
using Vehicles;

namespace Vehicles
{
    public interface IMotorcycle : IVehicle  //Interface som definierar grundl�ggande egenskaper och metoder f�r alla motorcyklar.
    {
        string EngineType { get; set; }
    }
}
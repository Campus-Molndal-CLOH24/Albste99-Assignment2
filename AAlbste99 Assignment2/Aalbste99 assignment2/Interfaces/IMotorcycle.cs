using System;
using Vehicles;

namespace Vehicles
{
    public interface IMotorcycle : IVehicle
    {
        string EngineType { get; set; }
    }
}
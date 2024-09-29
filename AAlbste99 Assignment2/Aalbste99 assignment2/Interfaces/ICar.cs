using System;
using Vehicles;

namespace Vehicles
{
    public interface ICar : IVehicle // Interface som definierar bilen
    {
        int Doors { get; set; }
    }
}
using System;
using Vehicles;

namespace Vehicles
{
    public interface ICar : IVehicle
    {
        int Doors { get; set; }
    }
}
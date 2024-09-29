using System;
using Vehicles;

namespace Vehicles
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string brand, string model, int year, double mileage);
    }

      
        
}

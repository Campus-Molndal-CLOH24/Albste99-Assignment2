using System;


namespace Vehicles
{
    public class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string brand, string model, int year, double mileage)
        {
            return new TruckImpl
            {
                Brand = brand,
                Model = model,
                Year = year,
                Mileage = mileage,
                CargoCapacity = 15000
            };
        }
        public ITruck CreateTruck(string brand, string model, int year, double mileage, int CargoCapacity)
        {
            return new TruckImpl
            {
                Brand = brand,
                Model = model,
                Year = year,
                Mileage = mileage,
                CargoCapacity = CargoCapacity
            };
        }
    }
    
    
}

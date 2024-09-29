using Vehicles;
using System.Reflection.Metadata.Ecma335;

namespace Vehicles
{
    public class MotorcycleFactory : IVehicleFactory  //MotorcycleFactory implementerar IVehicleFactory och ansvarar för att skapa Motorcykel objekt
    {
        public IMotorcycle CreateMotorcycle(string brand, string model, int year, double mileage, string enginetype)
        {
            return new Motorcycleimpl
            {
                Brand = brand,
                Model = model,
                Year = year,
                Mileage = mileage,
                EngineType = enginetype
            };
        }
        public IVehicle CreateVehicle(string brand,string model, int year, double mileage)
        {
            return CreateMotorcycle("Harley Davidson", model, year, mileage, "V-Twin");
        }
        
    }
}
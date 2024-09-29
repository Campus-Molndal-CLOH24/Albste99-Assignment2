using Vehicles;
using System.Reflection.Metadata.Ecma335;


namespace Vehicles
{
    public class CarFactory : IVehicleFactory  //CarFactory implenterar IVehicleFactory och ansvarar för att skapa bilobjekt
    {
        public ICar CreateCar(string brand, string model, int year, double mileage, int doors)
        {
            return new Carimpl
            {
                Brand = brand,
                Model = model,
                Year = year,
                Mileage = mileage,
                Doors = doors
            };
        }
        public IVehicle CreateVehicle(string brand, string model, int year, double mileage)
        {
                        return CreateCar("Toyota", model, year, mileage, 4);   
        }

    }
}

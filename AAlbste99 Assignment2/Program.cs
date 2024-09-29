using System;
using Vehicles;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDriveable> driveableVehicles = new List<IDriveable>(); //Lista för att lagra alla fordon som implementerar IDriveable

            var carFactory = new CarFactory();
            var motorcycleFactory = new MotorcycleFactory();  //Skapa fabriker för olika typer av fordon
            var TruckFactory = new TruckFactory();

            //Skapar körbara bilar
            IDriveable car1 = (IDriveable)carFactory.CreateVehicle("Toyota" ,"Corolla", 2020, 15000);
            IDriveable car2 = (IDriveable)carFactory.CreateVehicle("Ford", "Fiestaa", 2021, 20000);
            IDriveable car3 = (IDriveable)carFactory.CreateVehicle("Honda", "Civic", 2022, 12000);
            IDriveable car4 = (IDriveable)carFactory.CreateVehicle("Mercedes", "A180", 2019, 18000);
            IDriveable car5 = (IDriveable)carFactory.CreateVehicle("Toyota", "Supra", 2023, 5000);
            //Skapar körbara motorcyklar
            IDriveable motorcycle1 = (IDriveable)motorcycleFactory.CreateVehicle("Harley Davidson", "Sportster", 2019, 5000);
            IDriveable motorcycle2 = (IDriveable)motorcycleFactory.CreateVehicle("Kawasaki", "Z1000", 2020, 3000);
            IDriveable motorcycle3 = (IDriveable)motorcycleFactory.CreateVehicle("Harley Davidson", "V-Rod", 2018, 7000);
            IDriveable motorcycle4 = (IDriveable)motorcycleFactory.CreateVehicle("Kawasaki", "Ninja  ZX-6R", 2022, 4000);
            IDriveable motorcycle5 = (IDriveable)motorcycleFactory.CreateVehicle("Ducati", "Monster", 2023, 2000);
            //Skapar körbara lastbilar
            IDriveable truck1 = (IDriveable)TruckFactory.CreateVehicle("Volvo", "FH16", 2021, 50000);
            IDriveable truck2 = (IDriveable)TruckFactory.CreateVehicle("Scania", "R500", 2019, 80000);
            IDriveable truck3 = (IDriveable)TruckFactory.CreateVehicle("Mercedes", "Actros", 2020, 60000);
            //Lägger till dem i listan
            driveableVehicles.Add(car1);
            driveableVehicles.Add(car2);
            driveableVehicles.Add(car3);
            driveableVehicles.Add(car4);
            driveableVehicles.Add(car5);
           
            driveableVehicles.Add(motorcycle1);
            driveableVehicles.Add(motorcycle2);
            driveableVehicles.Add(motorcycle3);
            driveableVehicles.Add(motorcycle4);
            driveableVehicles.Add(motorcycle5);

            driveableVehicles.Add(truck1);
            driveableVehicles.Add(truck2);
            driveableVehicles.Add(truck3);


            foreach (var vehicle in driveableVehicles)
            {
                Console.WriteLine(vehicle.ToString());
                Console.WriteLine(vehicle.Drive());

            }
            //Skapa en lista för mina fordon
            List<IVehicle> vehicles = new List<IVehicle>();

            //lägg in fordon till listan
            vehicles.Add(new CarFactory().CreateCar("Toyota", "Corolla", 2020, 15000, 4));
            vehicles.Add(new CarFactory().CreateCar("Ford", "Fiestaa", 2021, 20000, 4));
            vehicles.Add(new CarFactory().CreateCar("Honda", "Civic", 2022, 12000, 4));
            vehicles.Add(new CarFactory().CreateCar("Mercedes", "A180", 2019, 18000, 4));
            vehicles.Add(new CarFactory().CreateCar("Toyota", "Supra", 2023, 5000, 2));

            vehicles.Add(new MotorcycleFactory().CreateMotorcycle("Harley Davdison", "Sportster", 2019, 5000, "V-Twin"));
            vehicles.Add(new MotorcycleFactory().CreateMotorcycle("Kawasaki", "Z1000", 2020, 3000, "Inline-4"));
            vehicles.Add(new MotorcycleFactory().CreateMotorcycle("Kawasaki", "Ninja  ZX-6R", 2022, 4000, "636CC"));
            vehicles.Add(new MotorcycleFactory().CreateMotorcycle("Ducati", "Monster", 2023, 2000, "L-Twin"));

            vehicles.Add(new TruckFactory().CreateTruck("Volvo", "FH16", 2021, 50000, 20000));
            vehicles.Add(new TruckFactory().CreateTruck("Scania", "R500", 2019, 80000, 18000));
            vehicles.Add(new TruckFactory().CreateTruck("Mercedes", "Actros", 2020, 60000, 15000));

            //iterera över listan och anropa metoder beroende på fordonstyp
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());

                if (vehicle is ICar Car)
                {
                    //Anropa metoder för bilar
                    Car.StartEngine();
                    Console.WriteLine("Car engine status: " + (Car.IsEngineOn() ? "On" : "Off"));
                    Car.StopEngine();
                    Console.WriteLine("Car engine status: " + (Car.IsEngineOn() ? "On" : "Off"));
                    Console.WriteLine("Car doors: " + Car.Doors);

                }
                else if (vehicle is IMotorcycle Motorcycle)
                {
                    Motorcycle.StartEngine();
                    Console.WriteLine("Motorcycle engine status: " + (Motorcycle.IsEngineOn() ? "On" : "Off"));
                    Motorcycle.StopEngine();
                    Console.WriteLine("Motorcycle engine status: " + (Motorcycle.IsEngineOn() ? "On" : "Off"));
                    Console.WriteLine("Motorcycle engine type: " + Motorcycle.EngineType);
                }
                else if (vehicle is ITruck truck)
                {
                    truck.StartEngine();
                    Console.WriteLine("Truck engine status: " + (truck.IsEngineOn() ? "On" : "Off"));
                    truck.StopEngine();
                    Console.WriteLine("Truck engine status: " + (truck.IsEngineOn() ? "On" : "Off"));
                    Console.WriteLine($"Truck cargo capacity: {truck.CargoCapacity} kg");
                }
            }
        }
    }
}
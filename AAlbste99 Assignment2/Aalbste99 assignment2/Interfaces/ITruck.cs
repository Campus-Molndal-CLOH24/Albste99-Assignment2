using System;
using Vehicles;

namespace Vehicles
{
    public interface ITruck : IVehicle  //Interface som specifikt för lastbilar, lägger till lastkapacitet
    {

     int CargoCapacity { get;  set;} //Lastkapacitet i kg eller ton

    }
   
    
}

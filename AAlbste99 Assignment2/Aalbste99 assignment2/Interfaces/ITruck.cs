using System;
using Vehicles;

namespace Vehicles
{
    public interface ITruck : IVehicle
    {

     int CargoCapacity { get;  set;} //Lastkapacitet i kg eller ton

    }
   
    
}

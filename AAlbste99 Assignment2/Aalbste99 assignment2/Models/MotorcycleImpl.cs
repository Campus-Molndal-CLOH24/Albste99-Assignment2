using Vehicles;

namespace Vehicles;

public class Motorcycleimpl : IMotorcycle, IDriveable  //Implementerar ett fordon med egenskaper och metoder f�r en motorcykel
{
    public string Drive() 
    {
        return "Driving the motorcycle";
    }
    public string? Brand { get; set; } = string.Empty;  //M�rke p� motorcykeln
    public string? Model { get; set; } = string.Empty;  //Modell p� motorcykeln
    public int Year { get; set; }  //Tillverknings�r
    public string? EngineType { get; set; } = string.Empty;  //Motortyp
    public double Mileage { get; set; }
   
    private bool EngineOn = false; //Egenskap f�r att h�lla koll p� motorn �r ig�ng eller inte
    public void StartEngine()  //Metod f�r att starta motorn
    {
        EngineOn = true;

    }
    public void StopEngine()  //Metod f�r att avsluta motorn
    {
        EngineOn = false;

    }
    public bool IsEngineOn()  //Metod f�r att kolla om motorn �r ig�ng
    {

        return EngineOn;
    }
    public override string ToString()  //ToString metod f�r att returnera information om motorcykeln
    {
        return $"Motorcycle: {Brand} {Model} ({Year}), Engine: {EngineType}, Mileage: {Mileage}";
    }
}
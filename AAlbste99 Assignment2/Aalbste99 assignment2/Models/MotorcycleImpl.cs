using Vehicles;

namespace Vehicles;

public class Motorcycleimpl : IMotorcycle, IDriveable  //Implementerar ett fordon med egenskaper och metoder för en motorcykel
{
    public string Drive() 
    {
        return "Driving the motorcycle";
    }
    public string? Brand { get; set; } = string.Empty;  //Märke på motorcykeln
    public string? Model { get; set; } = string.Empty;  //Modell på motorcykeln
    public int Year { get; set; }  //Tillverkningsår
    public string? EngineType { get; set; } = string.Empty;  //Motortyp
    public double Mileage { get; set; }
   
    private bool EngineOn = false; //Egenskap för att hålla koll på motorn är igång eller inte
    public void StartEngine()  //Metod för att starta motorn
    {
        EngineOn = true;

    }
    public void StopEngine()  //Metod för att avsluta motorn
    {
        EngineOn = false;

    }
    public bool IsEngineOn()  //Metod för att kolla om motorn är igång
    {

        return EngineOn;
    }
    public override string ToString()  //ToString metod för att returnera information om motorcykeln
    {
        return $"Motorcycle: {Brand} {Model} ({Year}), Engine: {EngineType}, Mileage: {Mileage}";
    }
}
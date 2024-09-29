using Vehicles;

namespace Vehicles;

public class Motorcycleimpl : IMotorcycle, IDriveable
{
    public string Drive() 
    {
        return "Driving the motorcycle";
    }
    public string? Brand { get; set; } = string.Empty;
    public string? Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public double MileAge { get; set; }
    public string EngineType { get; set; }
    public double Mileage { get; set; }
    
    private bool EngineOn = false;
    public void StartEngine()
    {
        EngineOn = true;

    }
    public void StopEngine()
    {
        EngineOn = false;

    }
    public bool IsEngineOn()
    {

        return EngineOn;
    }
    public override string ToString()
    {
        return $"Motorcycle: {Brand} {Model} ({Year}), Engine: {EngineType}, Mileage: {Mileage}";
    }
}
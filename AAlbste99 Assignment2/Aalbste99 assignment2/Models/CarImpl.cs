using Vehicles;
using System;

namespace Vehicles;
public class Carimpl : ICar, IDriveable
{
    public string Drive() // Drive metoden från Idriveable
    {
        return "Driving the car";
    }
    public string? Brand { get; set; } = string.Empty;//Bilens märke
    public string? Model { get; set; } = string.Empty; //Bilens modell
    public int Year { get; set; } //Tillverkningsår för bilen
    public double Mileage { get; set; }  //Bilens antal körda mil
    public int Doors { get; set; }  //Bilens antal dörrar


    private bool EngineOn = false;  //Anger om bilens motor är på eller av

    public void StartEngine()  //Metod för att starta motorn
    {

        EngineOn = true;
    }
    public void StopEngine() //Metod för att stänga av motorn
    {
    
    EngineOn = false;
    }
    public bool IsEngineOn()  //Metod för att kontrollera om motorn är på
    {

        return EngineOn; 
    }
    public override string ToString()  //Överskuggad ToString metod för att skriva ut bilens specifikationer
    {
        return $"Car: {Brand} {Model} ({Year}), Doors: {Doors}, Mileage: {Mileage}";
    }
}



    
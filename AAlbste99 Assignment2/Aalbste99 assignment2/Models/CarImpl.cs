using Vehicles;
using System;

namespace Vehicles;
public class Carimpl : ICar, IDriveable
{
    public string Drive() // Drive metoden fr�n Idriveable
    {
        return "Driving the car";
    }
    public string? Brand { get; set; } = string.Empty;//Bilens m�rke
    public string? Model { get; set; } = string.Empty; //Bilens modell
    public int Year { get; set; } //Tillverknings�r f�r bilen
    public double Mileage { get; set; }  //Bilens antal k�rda mil
    public int Doors { get; set; }  //Bilens antal d�rrar


    private bool EngineOn = false;  //Anger om bilens motor �r p� eller av

    public void StartEngine()  //Metod f�r att starta motorn
    {

        EngineOn = true;
    }
    public void StopEngine() //Metod f�r att st�nga av motorn
    {
    
    EngineOn = false;
    }
    public bool IsEngineOn()  //Metod f�r att kontrollera om motorn �r p�
    {

        return EngineOn; 
    }
    public override string ToString()  //�verskuggad ToString metod f�r att skriva ut bilens specifikationer
    {
        return $"Car: {Brand} {Model} ({Year}), Doors: {Doors}, Mileage: {Mileage}";
    }
}



    
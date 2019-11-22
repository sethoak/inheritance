using System;
using Csharp_InheritanceExercise;

//class zero inherits from vehicle
public class Zero : Vehicle
{  // Electric motorcycle
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero  drives past... Zooooom!");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Zero takes the second right after the light.");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero stops because the gas pedal broke.");
    }
}
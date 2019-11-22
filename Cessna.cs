using Csharp_InheritanceExercise;
using System;

public class Cessna : Vehicle
{  // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public void RefuelTank() { }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna  drives past... bUZZZzzzzZZZ");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Cessna takes a right at the fork.");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna stops because it ran into a mountain.");
    }
}
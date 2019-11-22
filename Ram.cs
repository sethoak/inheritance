using Csharp_InheritanceExercise;
using System;
public class Ram : Vehicle
{  // Gas powered truck
    public double FuelCapacity { get; set; }
    public void RefuelTank() { }

    public override string ToString()
    {
        return FuelCapacity.ToString();
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram  drives past... THATTHINGGOTAHEMI");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Ram misses his turn and goes on the gravel.");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Ram stops because he ran out of beer.");
    }
}
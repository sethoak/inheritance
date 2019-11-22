using System;
using Csharp_InheritanceExercise;

public class Tesla : Vehicle
{  // Electric car
    public double BatteryKWh { get; set; }
    public void ChargeBattery() { }
    //see 'virtual' above. We use overide to make it happen
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla drives past... zzZZzzzZ");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Tesla turns at the left.");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla stops because it ran out of electricity.");
    }
}
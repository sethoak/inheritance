using System;

//base class
public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }
    //define a method on a class. 1) accessability (public or private). 2 what it returns. 3 Parameters
    //overriding behavior. Recognizes that certain child classes will want to overide a behavior by using 'virtual'
    //you can use protected for allowing child access only instead of public too
    public virtual void Drive()
    {
        Console.WriteLine("Vroom!");
    }
    public virtual void Turn()
    {
        Console.WriteLine("carefully turn right at the fork.");
    }
    public virtual void Stop()
    {
        Console.WriteLine("gently stop your vehicle.");
    }
}
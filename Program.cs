using System;

namespace Csharp_InheritanceExercise
{
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
    }

    //class zero inherits from vehicle
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }
        public override void Drive()
        {
            Console.WriteLine("Zoooom!");
        }
    }

    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }
    }

    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }
        //see 'virtual' above. We use overide to make it happen
        public override void Drive()
        {
            Console.WriteLine("zzZZzzzZ");
        }
    }

    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }

        public override string ToString()
        {
            return FuelCapacity.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var zero = new Zero();
            var tesla = new Tesla();
            var cessna = new Cessna();
            var ram = new Ram();

            zero.MainColor = "White";
            tesla.MaximumOccupancy = 5;

            zero.Drive();
            tesla.Drive();
            cessna.Drive();
            ram.Drive();

            //ToString
            ram.FuelCapacity = 12;
            Console.WriteLine(ram);
        }
    }
}

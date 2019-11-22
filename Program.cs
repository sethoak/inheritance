using System;

namespace Csharp_InheritanceExercise
{

    class Program
    {
        static void Main(string[] args)
        {
            var zero = new Zero();
            var tesla = new Tesla();
            var cessna = new Cessna();
            var ram = new Ram();

            zero.MainColor = "White";
            tesla.MainColor = "Black";
            tesla.MaximumOccupancy = 5;
            cessna.MainColor = "Purple";
            ram.MainColor = "Red";

            zero.Drive();
            tesla.Drive();
            cessna.Drive();
            ram.Drive();
            zero.Turn();
            tesla.Turn();
            cessna.Turn();
            ram.Turn();
            zero.Stop();
            tesla.Stop();
            cessna.Stop();
            ram.Stop();

            //ToString
            ram.FuelCapacity = 12;
            Console.WriteLine(ram);
        }
    }
}

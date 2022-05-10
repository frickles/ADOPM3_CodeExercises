using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public enum Vehicles { Unknown, MC, Car, Scooter, Snowmobile, ElectricBike, Last};
        static void Main(string[] args)
        {
            var rnd = new Random();
            List<Vehicles> vehicles = new List<Vehicles>();
            for (int i = 0; i < 100; i++)
            {
                var v = (Vehicles) rnd.Next((int) Vehicles.Unknown+1, (int) Vehicles.Last);
                vehicles.Add(v);
            }
        }
    }
}
//Exercises:
//1.  Loop over all the Vehicle types in enum Vehicles and in the loop use vehicles.ForEach(),
//    Lambda and a captured variable to count and present number of vehicles of each type in vehicles.
//    - example MC: 25 / Car: 50 / ...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public int NumberOfWheels {get; set;} = 2;
        public string Color {get; set;}
        public override void DriveAbstract()
        {
            Console.WriteLine($"This {Make} {Model} is cruising down the highway.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"I spy a {Color} motorcycle speeding around town.");
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($"It is {Color} and has {NumberOfWheels} wheels.");
        }
    }
}
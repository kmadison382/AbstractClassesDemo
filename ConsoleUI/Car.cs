using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public int NumberOfDoors {get; set;} = 4;
        public bool CanGoFast {get; set;}
        public override void DriveAbstract()
        {
            Console.WriteLine($"This {Make} {Model} is {(CanGoFast == true ? "zooming" : "going")} down the road.");
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($"It has {NumberOfDoors} doors and {(CanGoFast == true ? "is speedy!" : "isn't that fast")}.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year {get; set;} = "year";
        public string Make {get; set;} = "make";
        public string Model {get; set;} = "model";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"I'm driving this {Year} {Make} {Model}.");
        }
        public virtual void GetDetails()
        {
            Console.WriteLine($"This is a {Year} {Make} {Model}.");
        }
        internal static List<Vehicle> vehicles = new List<Vehicle>();
        public Vehicle()
        {
            vehicles.Add(this);
        }
    }
}
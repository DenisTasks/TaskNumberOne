using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Interfaces;

namespace Hierarchy.Classes
{
    public abstract class Aircraft: IAircraft
    {
        public string Name { get; private set; }
        public int Carrying { get; private set; }
        public double FuelCapacity { get; private set; }
        public double Range { get; private set; }
        public int Crew { get; private set; }
        public Aircraft(string name, int carrying, double fuelcapacity, double range, int crew)
        {
            Name = name;
            Carrying = carrying;
            FuelCapacity = fuelcapacity;
            Range = range;
            Crew = crew;
        }
    }
}

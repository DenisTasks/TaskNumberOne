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
        public int FuelCapacity { get; private set; }
        public int Range { get; private set; }
        public int Crew { get; private set; }
        public Aircraft(string name, int carrying, int fuelcapacity, int range, int crew)
        {
            Name = name;
            Carrying = carrying;
            FuelCapacity = fuelcapacity;
            Range = range;
            Crew = crew;
        }
    }
}

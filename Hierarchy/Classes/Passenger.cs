using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Interfaces;

namespace Hierarchy.Classes
{
    public class Passenger: CommercialAviation, INumberOfPassengers
    {
        public int NumberOfPassengers { get; private set; }
        public Passenger(string name, int carrying, double fuelcapacity, double range, int crew,
            string regnumber, int numberofpassengers)
            : base(name, carrying, fuelcapacity, range, crew, regnumber)
        {
            NumberOfPassengers = numberofpassengers;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Interfaces;

namespace Hierarchy.Classes
{
    public class Freighter: CommercialAviation, ISizeOfCargo
    {
        public int SizeOfCargoSpace { get; private set; }
        public Freighter(string name, int carrying, double fuelcapacity, double range, int crew,
            string regnumber, int sizeofcargospace)
            : base(name, carrying, fuelcapacity, range, crew, regnumber)
        {
            SizeOfCargoSpace = sizeofcargospace;
        }
    }
}

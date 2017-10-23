using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Interfaces;

namespace Hierarchy.Classes
{
    public abstract class CommercialAviation: Aircraft, ICommercialAviation
    {
        public string RegNumber { get; private set; }
        public CommercialAviation(string name, int carrying, int fuelcapacity, int range, int crew,
            string regnumber)
            : base(name, carrying, fuelcapacity, range, crew)
        {
            RegNumber = regnumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Interfaces;

namespace Hierarchy.Classes
{
    public class AgriCultural: CommercialAviation, IAtomization
    {
        public Atomization Atomization { get; private set; }
        public AgriCultural(string name, int carrying, int fuelcapacity, int range, int crew,
            string regnumber, Atomization atomization)
            : base(name, carrying, fuelcapacity, range, crew, regnumber)
        {
            Atomization = atomization;
        }
    }
}

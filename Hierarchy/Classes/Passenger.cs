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
    }
}

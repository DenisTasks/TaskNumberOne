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
    }
}

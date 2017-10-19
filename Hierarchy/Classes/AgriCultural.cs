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
    }
}

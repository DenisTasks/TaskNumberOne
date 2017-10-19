using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Interfaces;

namespace Hierarchy.Classes
{
    public class MilitaryAviation: Aircraft, IMilitaryAviation
    {
        public int BoardNumber { get; private set; }
        public WeaponType WeaponType { get; private set; }
    }
}

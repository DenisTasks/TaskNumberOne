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
        public MilitaryAviation(string name, int carrying, double fuelcapacity, double range, int crew,
            int boardnumber, WeaponType weapontype) : base(name, carrying, fuelcapacity, range, crew)
        {
            BoardNumber = boardnumber;
            WeaponType = weapontype;
        }
    }
}

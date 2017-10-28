using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            WeaponType = weapontype;
            while (true)
            {
                if (Regex.IsMatch(boardnumber.ToString(), "^[0-9]{5,5}$"))
                {
                    BoardNumber = boardnumber;
                    break;
                }
                else
                {
                    // Invalid boardnumber;
                }
            }
        }
    }
}

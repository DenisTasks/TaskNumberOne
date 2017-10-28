using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Hierarchy.Interfaces;

namespace Hierarchy.Classes
{
    public abstract class CommercialAviation: Aircraft, ICommercialAviation
    {
        public string RegNumber { get; private set; }
        public CommercialAviation(string name, int carrying, double fuelcapacity, double range, int crew,
            string regnumber)
            : base(name, carrying, fuelcapacity, range, crew)
        {
            while (true)
            {
                if (Regex.IsMatch(regnumber, "^[A-Z]{2}-[0-9]{3}$"))
                {
                    RegNumber = regnumber;
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

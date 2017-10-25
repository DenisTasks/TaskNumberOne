using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Classes;

namespace Hierarchy.Factory
{
    public abstract class Creator
    {
        public abstract Aircraft FactoryMethod(string name, int carrying, double fuelcapacity, double range,
            int crew, string regnumber, int numberofpassengersORsizeofcargospace);
        public abstract Aircraft FactoryMethod(string name, int carrying, double fuelcapacity, double range,
            int crew, string regnumber, Atomization atomization);
        public abstract Aircraft FactoryMethod(string name, int carrying, double fuelcapacity, double range, int crew,
            int boardnumber, WeaponType weapontype);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Classes;

namespace Hierarchy.Factory
{
    public class NewFreighter : Creator
    {
        public override Aircraft FactoryMethod(string name, int carrying, double fuelcapacity, double range,
            int crew, string regnumber, int numberofpassengersORsizeofcargospace)
        {
            return new Freighter(name, carrying, fuelcapacity, range, crew, regnumber, numberofpassengersORsizeofcargospace);
        }
        public override Aircraft FactoryMethod(string name, int carrying, double fuelcapacity, double range,
            int crew, string regnumber, Atomization atomization)
        {
            throw new NotImplementedException();
        }
        public override Aircraft FactoryMethod(string name, int carrying, double fuelcapacity, double range, int crew,
            int boardnumber, WeaponType weapontype)
        {
            throw new NotImplementedException();
        }
    }
}

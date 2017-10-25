using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Classes;

namespace Hierarchy.Factory
{
    public class NewAgri : Creator
    {
        public override Aircraft FactoryMethod(string name, int carrying, double fuelcapacity, double range,
            int crew, string regnumber, int numberofpassengersORsizeofcargospace)
        {
            throw new NotImplementedException();
        }
        public override Aircraft FactoryMethod(string name, int carrying, double fuelcapacity, double range,
            int crew, string regnumber, Atomization atomization)
        {
            return new AgriCultural(name, carrying, fuelcapacity, range, crew, regnumber, atomization);
        }
        public override Aircraft FactoryMethod(string name, int carrying, double fuelcapacity, double range, int crew,
            int boardnumber, WeaponType weapontype)
        {
            throw new NotImplementedException();
        }
    }
}
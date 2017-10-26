using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Classes;

namespace Hierarchy.BuilderTemplate
{
    public class ConcreteBuilder: Builder
    {
        Airline company = new Airline();
        public override void BuildAircraftA()
        {
            company.Add(new Passenger("Boeng-747", 30, 2000, 1800, 5, "EW-1562", 301));
            company.Add(new Passenger("Boeng-737", 32, 1800, 1900, 6, "ES-1666", 340));
        }
        public override void BuildAircraftB()
        {
            company.Add(new Freighter("Airbus-900", 150, 3600, 3599, 2, "IT-8668", 220));
        }
        public override void BuildAircraftC()
        {
            company.Add(new AgriCultural("Messina-210", 12, 800, 500, 2, "BY-666", Atomization.Pescitides));
        }
        public override void BuildAircraftD()
        {
            company.Add(new MilitaryAviation("SU-425", 15, 1200, 1099, 1, 2017, WeaponType.Rocket));
        }
        public override Airline GetCompany()
        {
            return company;
        }
    }
}

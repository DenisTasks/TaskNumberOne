using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Classes;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Airline MyAirline = new Airline();
            Passenger pass1 = new Passenger("Boeng-747", 30, 2000, 1800, 5, "EW-1562", 301);
            Passenger pass2 = new Passenger("Boeng-737", 32, 1800, 1900, 6, "ES-1666", 340);
            Freighter cargo1 = new Freighter("Airbus-900", 210, 3600, 3599, 2, "IT-8668", 180);
            AgriCultural agri1 = new AgriCultural("Messina-210", 12, 800, 500, 2, "BY-666", Atomization.Pescitides);
            MilitaryAviation war1 = new MilitaryAviation("SU-425", 15, 1200, 1099, 1, 2017, WeaponType.Rocket);
            MyAirline.AddAircraftRange(pass1, pass2, cargo1, agri1, war1);

            Console.WriteLine("Общая вместимость флота компании " + MyAirline.GetSummaryPeople() + " чел.");
            Console.WriteLine("Общая грузоподъемность авиакомпании " + MyAirline.GetSummaryCarrying() + " т.");
            Console.WriteLine("Сортировка по дальности полета: ");
            foreach (var item in MyAirline.SortByRange())
            {
                Console.WriteLine(item.Name + " имеет дальность полета " + item.Range + " км.");
            }
            foreach (var item in MyAirline.SearchOfFuel(0.99, 1.01))
            {
                Console.WriteLine(item.Name + " попадает в заданный диапазон потребления горючего и имеет " + item.FuelCapacity + " л.");
            }
            Console.ReadKey();
        }
    }
}

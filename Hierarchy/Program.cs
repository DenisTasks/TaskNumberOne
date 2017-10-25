using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Classes;
using Hierarchy.Factory;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Airline MyAirline = new Airline();
            #region AddAircrafts
            Creator[] creators = new Creator[4];
            creators[0] = new NewPass();
            creators[1] = new NewFreighter();
            creators[2] = new NewAgri();
            creators[3] = new NewMilitary();
            foreach (var item in creators)
            {
                if (item is NewPass)
                {
                    MyAirline.Add(item.FactoryMethod("Boeng-747", 30, 2000, 1800, 5, "EW-1562", 301));
                    MyAirline.Add(item.FactoryMethod("Boeng-737", 32, 1800, 1900, 6, "ES-1666", 340));
                }
                if (item is NewFreighter)
                {
                    MyAirline.Add(item.FactoryMethod("Airbus-900", 150, 3600, 3599, 2, "IT-8668", 220));
                }
                if (item is NewAgri)
                {
                    MyAirline.Add(item.FactoryMethod("Messina-210", 12, 800, 500, 2, "BY-666", Atomization.Pescitides));
                }
                if (item is NewMilitary)
                {
                    MyAirline.Add(item.FactoryMethod("SU-425", 15, 1200, 1099, 1, 2017, WeaponType.Rocket));
                }
            #endregion
            }
            Console.WriteLine("Общая вместимость флота компании " + MyAirline.GetSummaryPeople() + " чел.");
            Console.WriteLine("________________________________");
            Console.WriteLine("Общая грузоподъемность авиакомпании " + MyAirline.GetSummaryCarrying() + " т.");
            Console.WriteLine("________________________________");
            Console.WriteLine("Сортировка по дальности полета: ");
            foreach (var item in MyAirline.SortByRange())
            {
                Console.WriteLine(item.Name + " имеет дальность полета " + item.Range + " км.");
            }
            Console.WriteLine("________________________________");
            foreach (var item in MyAirline.SearchOfFuel(0.94, 1.01))
            {
                Console.WriteLine(item.Name + " в диапазоне данного потребления горючего.");
            }
            Console.ReadKey();
        }
    }
}

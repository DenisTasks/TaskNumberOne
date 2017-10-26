using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Classes;
using Hierarchy.Factory;
using Hierarchy.BuilderTemplate;
using Hierarchy.Interfaces;

namespace Hierarchy
{
    class Program
    {
        public static Airline CreateFromBuilder()
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Airline company = builder.GetCompany();
            return company;
        }
        public static Airline CreateFromFactory()
        {
            Airline company = new Airline();
            Creator[] creators = new Creator[4];
            creators[0] = new NewPass();
            creators[1] = new NewFreighter();
            creators[2] = new NewAgri();
            creators[3] = new NewMilitary();
            foreach (var item in creators)
            {
                if (item is NewPass)
                {
                    company.Add(item.FactoryMethod("Boeng-747", 30, 2000, 1800, 5, "EW-1562", 301));
                    company.Add(item.FactoryMethod("Boeng-737", 32, 1800, 1900, 6, "ES-1666", 340));
                }
                if (item is NewFreighter)
                {
                    company.Add(item.FactoryMethod("Airbus-900", 150, 3600, 3599, 2, "IT-8668", 220));
                }
                if (item is NewAgri)
                {
                    company.Add(item.FactoryMethod("Messina-210", 12, 800, 500, 2, "BY-666", Atomization.Pescitides));
                }
                if (item is NewMilitary)
                {
                    company.Add(item.FactoryMethod("SU-425", 15, 1200, 1099, 1, 2017, WeaponType.Rocket));
                }
            }
            return company;
        }

        static void Main(string[] args)
        {
            IAirline MyAirline = CreateFromFactory();
            IAirline MyBelavia = CreateFromBuilder();

            Console.WriteLine("Общая вместимость флота компании {0} чел.", MyAirline.GetSummaryPeople());
            Console.WriteLine("________________________________");
            Console.WriteLine("Общая грузоподъемность авиакомпании {0} т.", MyAirline.GetSummaryCarrying());
            Console.WriteLine("________________________________");
            Console.WriteLine("Сортировка по дальности полета: ");
            foreach (var item in MyAirline.SortByRange())
            {
                Console.WriteLine("{0} имеет дальность полета {1} км.", item.Name, item.Range);
            }
            Console.WriteLine("________________________________");
            foreach (var item in MyAirline.SearchByFuel(0.94, 1.01))
            {
                Console.WriteLine("{0} в диапазоне данного потребления горючего.", item.Name);
            }
            Console.ReadKey();
        }
    }
}

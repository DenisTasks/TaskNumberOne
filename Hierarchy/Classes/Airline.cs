using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Interfaces;

namespace Hierarchy.Classes
{
    public class Airline : IAirline
    {
        private ICollection<Aircraft> MyAirline;
        public Airline()
        {
            MyAirline = new List<Aircraft>();
        }
        public void Add(Aircraft aircraft)
        {
            MyAirline.Add(aircraft);
        }
        public int GetSummaryPeople()
        {
            int summ = 0;
            foreach (var item in MyAirline)
            {
                summ += item.Crew;
                summ = (item is Passenger) ? (summ + ((Passenger)item).NumberOfPassengers) : (summ);
            }
            return summ;
        }
        public int GetSummaryCarrying()
        {
            int summ = 0;
            foreach (var item in MyAirline)
            {
                summ += item.Carrying;
                summ = (item is Freighter) ? (summ + ((Freighter)item).SizeOfCargoSpace) : (summ);
            }
            return summ;
        }
        public IEnumerable<Aircraft> Aircrafts()
        {
            return MyAirline;
        }
        public IEnumerable<Aircraft> SortByRange()
        {
            return MyAirline.OrderBy(x => x.Range).ToArray();
        }
        public IEnumerable<Aircraft> SearchByFuel(double a, double b)
        {
            return MyAirline.Where(x => ((x.FuelCapacity / x.Range) >= a) && ((x.FuelCapacity / x.Range) <= b)).ToArray();
        }
    }
}

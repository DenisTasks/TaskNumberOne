using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hierarchy.Classes
{
    public class Airline
    {
        List<Aircraft> MyAirline;
        public Airline()
        {
            MyAirline = new List<Aircraft>();
        }
        public void AddAircraftRange(params Aircraft[] aircrafts)
        {
            MyAirline.AddRange(aircrafts);
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
        public IEnumerable<Aircraft> SortByRange()
        {
            return MyAirline.OrderBy(x => x.Range).ToList();
        }
        public IEnumerable<Aircraft> SearchOfFuel(double a, double b)
        {
            return MyAirline.Where(x => (((double)x.FuelCapacity / (double)x.Range) >= a) && (((double)x.FuelCapacity / (double)x.Range) <= b)).ToList();
        }
    }
}

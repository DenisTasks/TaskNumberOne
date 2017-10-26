using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Classes;

namespace Hierarchy.Interfaces
{
    public interface IAirline
    {
        void Add(Aircraft aircraft);
        int GetSummaryPeople();
        int GetSummaryCarrying();
        IEnumerable<Aircraft> Aircrafts();
        IEnumerable<Aircraft> SortByRange();
        IEnumerable<Aircraft> SearchByFuel(double a, double b);
    }
}

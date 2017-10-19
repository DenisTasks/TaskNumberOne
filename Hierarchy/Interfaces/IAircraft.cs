using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hierarchy.Interfaces
{
    public interface IAircraft
    {
        string Name { get; }
        int Carrying { get; }
        int FuelCapacity { get; }
        int Range { get; }
        int Crew { get; }
    }
}

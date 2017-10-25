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
        double FuelCapacity { get; }
        double Range { get; }
        int Crew { get; }
    }
}

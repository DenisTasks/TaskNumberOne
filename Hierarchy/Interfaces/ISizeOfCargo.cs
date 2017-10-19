using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hierarchy.Interfaces
{
    public interface ISizeOfCargo: ICommercialAviation
    {
        int SizeOfCargoSpace { get; }
    }
}

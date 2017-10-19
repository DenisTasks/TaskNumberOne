using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Classes;

namespace Hierarchy.Interfaces
{
    public interface IMilitaryAviation: IAircraft
    {
        int BoardNumber { get; }
        WeaponType WeaponType { get; }
    }
}

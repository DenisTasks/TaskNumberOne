using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Interfaces;

namespace Hierarchy.Classes
{
    public class CommercialAviation: Aircraft, ICommercialAviation
    {
        public string RegNumber { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hierarchy.Classes;

namespace Hierarchy.BuilderTemplate
{
    public abstract class Builder
    {
        public abstract void BuildAircraftA();
        public abstract void BuildAircraftB();
        public abstract void BuildAircraftC();
        public abstract void BuildAircraftD();
        public abstract Airline GetCompany();
    }
}

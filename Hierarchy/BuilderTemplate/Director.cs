using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hierarchy.BuilderTemplate
{
    class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.BuildAircraftA();
            builder.BuildAircraftB();
            builder.BuildAircraftC();
            builder.BuildAircraftD();
        }
    }
}

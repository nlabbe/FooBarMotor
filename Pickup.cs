using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooBarMotor
{
    public class Pickup : AbstractVan
    {
        public Pickup(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public Pickup(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooBarMotor
{
    public class Coupe : AbstractCar
    {
        public Coupe(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public Coupe(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
            
        }
    }
}

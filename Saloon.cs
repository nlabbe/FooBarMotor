using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooBarMotor
{
    public class Saloon : AbstractCar
    {
        public Saloon(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public Saloon(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
            
        }
    }
}

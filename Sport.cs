using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooBarMotor
{
    public class Sport : AbstractCar
    {
        public Sport(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {

        }
        public Sport(IEngine engine, VehicleColour colour) : base(engine, colour)
        {

        }
    }
}

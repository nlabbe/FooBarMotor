using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooBarMotor
{
    public class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {

        }
        public AbstractCar(IEngine engine, VehicleColour colour) : base(engine, colour)
        {

        }
    }
}

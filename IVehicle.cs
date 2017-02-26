using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FooBarMotor
{
    public enum VehicleColour
    {
        Unpainted, Blue, Black, Green, Red, Silver, White, Yellow
    }
    public interface IVehicle
    {
        IEngine Engine {get;}
        VehicleColour Colour {get;}
        void Paint(VehicleColour colour);        
    }
}

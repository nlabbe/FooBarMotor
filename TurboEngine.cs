using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooBarMotor
{
    public class TurboEngine : AbstractEngine
    {
        public TurboEngine(int size) : base(size, true)
        {
            // turbocharged
        }
    }
}

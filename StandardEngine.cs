using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooBarMotor
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size) : base(size, false)
        {
            // not turbocharged
        }
    }
}

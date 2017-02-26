using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooBarMotor
{
    public interface IEngine
    {
        int Size { get; }
        bool Turbo { get;}

    }
}

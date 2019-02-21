using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.BasicStructure
{
    abstract class Flyweight
    {
        public abstract void Operation(int extrinsicState);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.BasicStructure
{
    class UnSharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicState)
        {
            Console.WriteLine("不共享的具体Flyweight:" + extrinsicState);
        }
    }
}

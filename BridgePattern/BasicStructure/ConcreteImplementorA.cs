﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BasicStructure
{
    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现A的方法执行");
        }
    }
}

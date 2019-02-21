using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BasicStructure
{
    /// <summary>
    /// 具体装饰类 A
    /// </summary>
    class ConcreteDecoratorA : Decorator
    {
        private string _addedState;

        public override void Operation()
        {
            base.Operation();
            _addedState = "new state";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
}

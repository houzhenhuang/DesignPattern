using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BasicStructure
{
    /// <summary>
    /// 装饰抽象类
    /// </summary>
    abstract class Decorator : Component
    {
        protected Component Component { get; set; }

        public void SetComponent(Component component)
        {
            this.Component = component;
        }
        public override void Operation()
        {
            if (Component != null)
            {
                Component.Operation();
            }
        }
    }
}

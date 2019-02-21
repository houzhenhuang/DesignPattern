using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.SituationSimulation
{
    /// <summary>
    /// 手机抽象类，即装饰者模式中的抽象组件类
    /// </summary>
    abstract class Handset
    {
        public abstract void Operation();
    }
}

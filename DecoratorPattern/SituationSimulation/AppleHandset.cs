using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.SituationSimulation
{
    /// <summary>
    /// 苹果手机手机类，即装饰着模式中的具体组件类
    /// </summary>
    class AppleHandset : Handset
    {
        public override void Operation()
        {
            Console.WriteLine("操作苹果手机");
        }
    }
}

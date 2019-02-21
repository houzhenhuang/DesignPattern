using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.SituationSimulation
{
    /// <summary>
    /// 手机保护套
    /// </summary>
    class HandsetCasing : HandsetDecorator
    {
        public HandsetCasing(Handset handset)
            : base(handset)
        {

        }
        public override void Operation()
        {
            base.Operation();
            AddCasing();
        }
        public void AddCasing()
        {
            Console.WriteLine("给手机戴保护套");
        }
    }
}

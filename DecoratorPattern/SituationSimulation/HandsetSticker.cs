using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.SituationSimulation
{
    /// <summary>
    /// 贴纸
    /// </summary>
    class HandsetSticker : HandsetDecorator
    {
        public HandsetSticker(Handset handset)
            : base(handset)
        {

        }
        public override void Operation()
        {
            base.Operation();
            AddSticker();
        }
        public void AddSticker()
        {
            Console.WriteLine("给手机贴膜");
        }
    }
}

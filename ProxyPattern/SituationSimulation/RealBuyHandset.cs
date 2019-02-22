using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.SituationSimulation
{
    class RealBuyHandset : BuyHandset
    {
        public override void BuyAppleHandset()
        {
            Console.WriteLine($"{this.GetType().Name}购买了一部苹果手机！");
        }
    }
}

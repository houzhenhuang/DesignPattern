using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.SituationSimulation
{
    class BuyHandsetProxy : BuyHandset
    {
        BuyHandset buyHandset;

        public override void BuyAppleHandset()
        {
            if (buyHandset == null)
            {
                buyHandset = new RealBuyHandset();
            }
            buyHandset.BuyAppleHandset();
        }
    }
}

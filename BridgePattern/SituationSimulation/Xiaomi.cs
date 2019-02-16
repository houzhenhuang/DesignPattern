using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.SituationSimulation
{
    /// <summary>
    /// 小米手机
    /// </summary>
    class Xiaomi : HandsetBrand
    {
        public override void Run(string name)
        {
            handsetSoft.Run(name);
        }
    }
}

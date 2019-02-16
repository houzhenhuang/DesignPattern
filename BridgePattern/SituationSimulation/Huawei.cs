using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.SituationSimulation
{
    /// <summary>
    /// 华为手机
    /// </summary>
    class Huawei : HandsetBrand
    {
        public override void Run(string name)
        {
            handsetSoft.Run(name);
        }
    }
}

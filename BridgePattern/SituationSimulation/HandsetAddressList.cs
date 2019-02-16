using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.SituationSimulation
{
    /// <summary>
    /// 手机通讯录类
    /// </summary>
    class HandsetAddressList : HandsetSoft
    {
        public override void Run(string name)
        {
            Console.WriteLine($"{name}手机正在运行手机通讯录");
        }
    }
}

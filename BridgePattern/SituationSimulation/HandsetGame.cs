using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.SituationSimulation
{
    /// <summary>
    /// 手机游戏类
    /// </summary>
    class HandsetGame : HandsetSoft
    {
        public override void Run(string name)
        {
            Console.WriteLine($"{name}手机正在运行手机游戏");
        }
    }
}

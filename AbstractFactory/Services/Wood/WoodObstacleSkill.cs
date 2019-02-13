using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory.Wood
{
    /// <summary>
    /// 障碍技能类
    /// </summary>
    public class WoodObstacleSkill : ISkill
    {
        public void ReleaseSkill()
        {
            Console.WriteLine("木系障碍技能-见血封喉");
        }
    }
}

using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory.Gold
{
    /// <summary>
    /// 障碍技能类
    /// </summary>
    public class GoldObstacleSkill : ISkill
    {
        public void ReleaseSkill()
        {
            Console.WriteLine("金系障碍技能-流连忘返");
        }
    }
}

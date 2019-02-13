using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory.Wood
{
    /// <summary>
    /// 法术攻击技能类
    /// </summary>
    public class WoodMagicAttackSkill : ISkill
    {
        public void ReleaseSkill()
        {
            Console.WriteLine("木系法术攻击技能-摘叶飞花");
        }
    }
}

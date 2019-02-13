using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory.Gold
{
    /// <summary>
    /// 法术攻击技能类
    /// </summary>
    public class GoldMagicAttackSkill : ISkill
    {
        public void ReleaseSkill()
        {
            Console.WriteLine("金系法术攻击技能-金光乍现");
        }
    }
}

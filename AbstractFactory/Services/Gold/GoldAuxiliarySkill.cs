using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory.Gold
{
    /// <summary>
    /// 辅助技能类
    /// </summary>
    public class GoldAuxiliarySkill : ISkill
    {
        public void ReleaseSkill()
        {
            Console.WriteLine("金系辅助技能-天生神力");
        }
    }
}

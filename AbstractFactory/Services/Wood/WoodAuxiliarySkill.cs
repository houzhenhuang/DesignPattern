using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory.Wood
{
    /// <summary>
    /// 辅助技能类
    /// </summary>
    public class WoodAuxiliarySkill : ISkill
    {
        public void ReleaseSkill()
        {
            Console.WriteLine("木系辅助技能-揠苗助长");
        }
    }
}

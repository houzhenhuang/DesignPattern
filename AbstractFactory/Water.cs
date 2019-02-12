using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 水系门派
    /// </summary>
    public class Water : ISects
    {
        public void Skill()
        {
            Console.WriteLine("水系门派技能：滴水穿石");
        }
    }
}

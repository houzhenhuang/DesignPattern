using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 木系门派
    /// </summary>
    public class Wood : ISects
    {
        public void Skill()
        {
            Console.WriteLine("木系门派技能：摘叶飞花");
        }
    }
}

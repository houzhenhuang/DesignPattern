using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 金系门派
    /// </summary>
    public class Gold : ISects
    {
        public void Skill()
        {
            Console.WriteLine("金系门派技能：金光乍现");
        }
    }
}

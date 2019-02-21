using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.SituationSimulation
{
    /// <summary>
    /// 具体网站类
    /// </summary>
    class ConcreteWebSite : WebSite
    {
        public string Name { get; }
        public ConcreteWebSite(string name)
        {
            this.Name = name;
        }
        public override void Use()
        {
            Console.WriteLine("网站分类：" + Name);
        }
    }
}

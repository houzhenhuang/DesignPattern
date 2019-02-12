using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 创建水系门派工厂
    /// </summary>
    public class WaterFactory: IFactory
    {
        public ISects CreateInstance()
        {
            return new Water();
        }
    }
}

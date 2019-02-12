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
    /// 创建木系门派工厂
    /// </summary>
    public class WoodFactory: IFactory
    {
        public ISects CreateInstance()
        {
            return new Wood();
        }
    }
}

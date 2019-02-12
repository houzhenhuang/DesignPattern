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
    /// 抽象工厂
    /// </summary>
    public interface IFactory
    {
        ISects CreateInstance();
    }
}

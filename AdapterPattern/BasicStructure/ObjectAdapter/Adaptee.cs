using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.BasicStructure.ObjectAdapter
{
    /// <summary>
    /// 需要要适配的类
    /// </summary>
    class Adaptee
    {
        /// <summary>
        /// 特殊的请求
        /// </summary>
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求！");
        }
    }
}

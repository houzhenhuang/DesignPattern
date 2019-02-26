using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.BasicStructure
{
    abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        /// <summary>
        /// 模板方法
        /// 给出了逻辑的骨架，而逻辑的组成是一些相应的抽象操作
        /// 这些逻辑都推迟到子类实现
        /// </summary>
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}

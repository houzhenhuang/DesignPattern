using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Structural
{
    /// <summary>
    /// 产品类
    /// </summary>
    class Product
    {
        IList<string> parts = new List<string>();
        /// <summary>
        /// 添加产品部件
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\n产品 创建----");
            //列举所有产品部件
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}

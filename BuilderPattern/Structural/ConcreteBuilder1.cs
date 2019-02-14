using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Structural
{
    class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();
        /// <summary>
        /// 构建部件A
        /// </summary>
        public override void BuilderPartA()
        {
            product.Add("ConcreteBuilder1 部件A");
        }
        /// <summary>
        /// 构建部件B
        /// </summary>
        public override void BuilderPartB()
        {
            product.Add("ConcreteBuilder1 部件B");
        }
        /// <summary>
        /// 获取产品
        /// </summary>
        /// <returns></returns>
        public override Product GetResult()
        {
            return product;
        }
    }
}

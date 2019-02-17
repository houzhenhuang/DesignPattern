using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.BasicStructure
{
    /// <summary>
    /// 叶节点对象
    /// </summary>
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }
        public override void Add(Component component)
        {
            Console.WriteLine("不能添加一个叶节点");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("不能删除一个叶节点");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}

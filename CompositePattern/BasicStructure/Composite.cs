using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.BasicStructure
{
    /// <summary>
    /// 枝节点对象
    /// </summary>
    class Composite : Component
    {
        private IList<Component> children = new List<Component>();
        public Composite(string name)
            : base(name)
        { }
        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}

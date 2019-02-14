using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.PrototypePattern
{
    /// <summary>
    /// 具体原型
    /// </summary>
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id) : base(id)
        {

        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}

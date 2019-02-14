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
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id) : base(id)
        {

        }
        /// <summary>
        /// 创建当前对象的浅表副本。
        /// 方法是创建一个新对象，然后将当前对象的非静态字段复制到该新对象。
        /// 如果字段是值类型的，则对该字段进行逐位复制。
        /// 如果字段是引用类型的，则复制引用，但不复制引用的对象，因此，原始对象及其副本引用同一个对象
        /// </summary>
        /// <returns></returns>
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}

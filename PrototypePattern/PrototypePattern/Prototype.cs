using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.PrototypePattern
{
    abstract class Prototype
    {
        public int Id { get; set; }
        public Prototype(int id)
        {
            this.Id = id;
        }

        public abstract Prototype Clone();//这个抽象类的关键就是这个Clone方法
    }
}

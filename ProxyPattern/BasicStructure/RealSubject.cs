using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.BasicStructure
{
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine($"真实的请求:{this.GetType()}");
        }
    }
}

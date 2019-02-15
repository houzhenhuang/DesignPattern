using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.BasicStructure.ClassAdapter
{
    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            this.SpecificRequest();
        }
    }
}

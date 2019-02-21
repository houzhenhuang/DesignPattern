using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.BasicStructure
{
    /// <summary>
    /// 外观类
    /// </summary>
    class Facade
    {
        private SubSystemOne _subSystemOne;
        private SubSystemTwo _subSystemTwo;
        private SubSystemThree _subSystemThree;
        private SubSystemFour _subSystemFour;

        public Facade()
        {
            _subSystemOne = new SubSystemOne();
            _subSystemTwo = new SubSystemTwo();
            _subSystemThree = new SubSystemThree();
            _subSystemFour = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n方法组A() ---");
            _subSystemOne.Method();
            _subSystemTwo.Method();
            _subSystemFour.Method();
        }
        public void MethodB()
        {
            Console.WriteLine("\n方法组B() ---");
            _subSystemTwo.Method();
            _subSystemThree.Method();
        }
    }
}

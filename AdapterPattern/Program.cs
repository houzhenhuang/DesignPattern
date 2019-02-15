using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {//BasicStructure-ClassAdapter
                    BasicStructure.ClassAdapter.ITarget target = new BasicStructure.ClassAdapter.Adapter();
                    //表面看像是调用了Request()方法,但实际是调用了SpecificRequest()方法
                    target.Request();
                }
                {//BasicStructure-ObjectAdapter
                    BasicStructure.ObjectAdapter.ITarget target = new BasicStructure.ObjectAdapter.Adapter();
                    //表面看像是调用了Request()方法,但实际是调用了SpecificRequest()方法
                    target.Request();
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

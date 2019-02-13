using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IColor red = new ReadColor();
                red.Red = 1;
                IColor green = red.Clone();
                green.Red = 2;

                Console.WriteLine($"red.Red={red.Red},green.Red={green.Red}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.BasicStructure;
using TemplateMethodPattern.SituationSimulation;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {//BasicStructure
                    AbstractClass c = new ConcreteClassA();
                    c.TemplateMethod();

                    c = new ConcreteClassB();
                    c.TemplateMethod();
                }
                {//SituationSimulation
                    AppleHandset appleHandset = new AppleHandset64G();
                    appleHandset.Assemble();

                    appleHandset = new AppleHandset128G();
                    appleHandset.Assemble();
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

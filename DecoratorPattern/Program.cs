using DecoratorPattern.BasicStructure;
using DecoratorPattern.SituationSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
    static void Main(string[] args)
    {
        try
        {
            {//BasicStructure
                ConcreteComponent c = new ConcreteComponent();
                ConcreteDecoratorA d1 = new ConcreteDecoratorA();
                ConcreteDecoratorB d2 = new ConcreteDecoratorB();

                d1.SetComponent(c);
                d2.SetComponent(d1);

                d2.Operation();
            }
            {//SituationSimulation
                //第一种写法
                Console.WriteLine("***************第一种写法：***************");
                AppleHandset handset = new AppleHandset();
                HandsetSticker handsetSticker = new HandsetSticker(handset);
                HandsetCasing handsetCasing = new HandsetCasing(handsetSticker);
                handsetCasing.Operation();

                //第二种写法
                Console.WriteLine("***************第二种写法：***************");
                Handset appleHandset = new AppleHandset();
                appleHandset = new HandsetSticker(appleHandset);
                appleHandset = new HandsetCasing(appleHandset);

                appleHandset.Operation();
                //第二种写法的简化
                Console.WriteLine("***************第二种写法的简化：***************");
                new HandsetCasing(new HandsetSticker(new AppleHandset())).Operation();
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

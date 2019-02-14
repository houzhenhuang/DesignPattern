using BuilderPattern.SituationSimulation;
using BuilderPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
    static void Main(string[] args)
    {
        try
        {
            {//建造者模式基本代码
                //Director director = new Director();
                //Builder b1 = new ConcreteBuilder1();
                //Builder b2 = new ConcreteBuilder2();

                //director.Construct(b1);
                //Product p1 = b1.GetResult();
                //p1.Show();
            }

            {//建造者模式实现交通工具的构造
                Shop shop = new Shop();
                VehicleBuilder motorCycleBuilder = new MotorCycleBuilder();
                    
                shop.Construct(motorCycleBuilder);
                Vehicle motorCycle = motorCycleBuilder.Vehicle;
                motorCycle.Show();

                VehicleBuilder carCycleBuilder = new CarCycleBuilder();
                shop.Construct(carCycleBuilder);
                Vehicle car = motorCycleBuilder.Vehicle;
                car.Show();
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

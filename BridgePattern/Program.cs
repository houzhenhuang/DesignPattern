using BridgePattern.BasicStructure;
using BridgePattern.SituationSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 桥接模式
    /// 能很好的满足：开闭原则
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {//BasicStructure
                    Abstraction abstraction = new RefinedAbstraction();
                    abstraction.SetImplementor(new ConcreteImplementorA());
                    abstraction.Operation();
                }
                {//SituationSimulation
                    HandsetBrand huawei = new Huawei();
                    huawei.SetHandsetBrand(new HandsetGame());
                    huawei.Run("华为");

                    HandsetBrand xiaomi = new Xiaomi();
                    xiaomi.SetHandsetBrand(new HandsetGame());
                    xiaomi.Run("小米");
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

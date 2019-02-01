using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 单一职责原则
    /// 里氏替换原责
    /// 依赖倒置原责
    /// 接口隔离原则
    /// 迪米特法则
    /// 开闭原责
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {//普通调用
                    //ISects gold = new Gold();
                    //gold.Skill();

                    //ISects wood = new Wood();
                    //wood.Skill();

                    //ISects water = new Water();
                    //water.Skill();
                }
                {//用简单工厂实现
                    //ISects gold = Factory.CreateInstance(Factory.SectsType.Gold);
                    //gold.Skill();

                    //ISects wood = Factory.CreateInstance(Factory.SectsType.Wood);
                    //gold.Skill();
                }
                {//用简单工厂+配置文件
                    //ISects gold = Factory.CreateInstanceWithConfig();
                    //gold.Skill();
                }

                {//用简单工厂+配置文件+反射
                    ISects wood = Factory.CreateInstanceWithReflect();
                    wood.Skill();
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

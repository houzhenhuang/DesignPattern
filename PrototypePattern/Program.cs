using PrototypePattern.PrototypePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// Client
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {
                    //Resume a = new Resume("tom");
                    //a.SetPersonalInfo("男", 21);
                    //a.SetWorkExperience("1998-2000", "XXX公司");

                    //Resume b = new Resume("tom");
                    //b.SetPersonalInfo("男", 21);
                    //b.SetWorkExperience("1998-2000", "XXX公司");

                    //Resume c = new Resume("tom");
                    //c.SetPersonalInfo("男", 21);
                    //c.SetWorkExperience("1998-2000", "XXX公司");

                    //a.Show();
                    //b.Show();
                    //c.Show();
                }
                {
                    //Resume a = new Resume("tom");
                    //a.SetPersonalInfo("男", 21);
                    //a.SetWorkExperience("1998-2000", "XXX公司");

                    //Resume b = a;
                    //Resume c = a;

                    //a.Show();
                    //b.Show();
                    //c.Show();
                }
                {//Prototype example
                    //ConcretePrototype1 p1 = new ConcretePrototype1(1);
                    //ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();

                    //Console.WriteLine($"p1.Id={p1.Id},c1.Id={c1.Id}");
                    //c1.Id = 2;
                    //Console.WriteLine($"p1.Id={p1.Id},c1.Id={c1.Id}");
                }
                {//用原型模式实现简历
                    //Resume a = new Resume("tom");
                    //a.SetPersonalInfo("男", 21);
                    //a.SetWorkExperience("1998-2000", "XXX公司");

                    //Resume b = (Resume)a.Clone();
                    //b.SetWorkExperience("2000-2002", "YYY公司");

                    //Resume c = (Resume)a.Clone();
                    //c.SetWorkExperience("2002-2004", "ZZZ公司");

                    //a.Show();
                    //b.Show();
                    //c.Show();
                }
                {//浅拷贝
                    //Resume a = new Resume("tom");
                    //a.SetPersonalInfo("男", 21);
                    //a.SetWorkExperience("1998-2000", "XXX公司");

                    //Resume b = (Resume)a.Clone();
                    //b.SetWorkExperience("2000-2002", "YYY公司");

                    //Resume c = (Resume)a.Clone();
                    //c.SetWorkExperience("2002-2004", "ZZZ公司");

                    //a.Show();
                    //b.Show();
                    //c.Show();
                }
                {//深拷贝
                    Resume a = new Resume("tom");
                    a.SetPersonalInfo("男", 21);
                    a.SetWorkExperience("1998-2000", "XXX公司");

                    Resume b = (Resume)a.Clone();
                    b.SetWorkExperience("2000-2006", "YYY公司");

                    Resume c = (Resume)a.Clone();
                    c.SetWorkExperience("2002-2009", "ZZZ公司");

                    a.Show();
                    b.Show();
                    c.Show();
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

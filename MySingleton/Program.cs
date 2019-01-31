using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySingleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //{//单线程情况下
                //    for (int i = 0; i < 10; i++)
                //    {
                //        Singleton singleton = Singleton.CreateInstance();
                //        Console.WriteLine(singleton.GetResult());
                //    }
                //}
                //{//多线程情况下
                //    List<Task> tasks = new List<Task>();
                //    TaskFactory taskFactory = new TaskFactory();
                //    for (int i = 0; i < 10; i++)
                //    {
                //        tasks.Add(taskFactory.StartNew(() =>
                //        {
                //            Singleton singleton = Singleton.CreateInstance();
                //            Console.WriteLine(singleton.GetResult());
                //        }));
                //    }
                //    Task.WaitAll(tasks.ToArray());
                //}

                //{//多线程情况下(静态构造函数)
                //    List<Task> tasks = new List<Task>();
                //    TaskFactory taskFactory = new TaskFactory();
                //    for (int i = 0; i < 10; i++)
                //    {
                //        tasks.Add(taskFactory.StartNew(() =>
                //        {
                //            SingletonSecond singleton = SingletonSecond.CreateInstance();
                //            Console.WriteLine(singleton.GetResult());
                //        }));
                //    }
                //    Task.WaitAll(tasks.ToArray());
                //}
                {//多线程情况下(静态对象)
                    List<Task> tasks = new List<Task>();
                    TaskFactory taskFactory = new TaskFactory();
                    for (int i = 0; i < 10; i++)
                    {
                        tasks.Add(taskFactory.StartNew(() =>
                        {
                            SingletonThird singleton = SingletonThird.CreateInstance();
                            Console.WriteLine(singleton.GetResult());
                        }));
                    }
                    Task.WaitAll(tasks.ToArray());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}

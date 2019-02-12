using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{

    public class SingletonSecond
    {
        private static object singletonSecond_lock = new object();
        long lResult = 0;
        private SingletonSecond()
        {
            Console.WriteLine("被实例化了一次");
            for (int i = 0; i < 100000000; i++)
            {
                lResult += i;
            }
        }
        public long GetResult()
        {
            return lResult;
        }
        private static SingletonSecond _singletonSecond { get; set; }
        static SingletonSecond()
        {
            _singletonSecond = new SingletonSecond();
        }
        public static SingletonSecond CreateInstance()
        {
            return _singletonSecond;
        }
    }
}

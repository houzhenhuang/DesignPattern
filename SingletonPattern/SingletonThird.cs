using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{

    public class SingletonThird
    {
        private static object singletonSecond_lock = new object();
        long lResult = 0;
        private SingletonThird()
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
        private static SingletonThird _singletonThird = new SingletonThird();
        public static SingletonThird CreateInstance()
        {
            return _singletonThird;
        }
    }
}

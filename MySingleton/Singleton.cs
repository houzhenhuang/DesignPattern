using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySingleton
{

    public class Singleton
    {
        private static object singleton_lock = new object();
        long lResult = 0;
        private Singleton()
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
        private static Singleton _singleton { get; set; }
        public static Singleton CreateInstance()
        {
            lock (singleton_lock)
            {
                if (_singleton == null)
                {
                    _singleton = new Singleton();
                }
            }
            return _singleton;
        }
    }
}

using ProxyPattern.BasicStructure;
using ProxyPattern.SituationSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {//BasicStructure
                    Proxy proxy = new Proxy();
                    proxy.Request();
                }
                {//SituationSimulation
                    BuyHandsetProxy proxy = new BuyHandsetProxy();
                    proxy.BuyAppleHandset();
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

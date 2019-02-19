using FacadePattern.BasicStructure;
using FacadePattern.SituationSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {//BasicStructure
                 //由于Facade的作用，客户端根本不知道子4个子系统的存在
                    Facade facade = new Facade();
                    facade.MethodA();
                    facade.MethodB();
                }
                {//SituationSimulation
                    NotebookPowerSupply notebookPowerSupply = new NotebookPowerSupply();
                    notebookPowerSupply.Open();
                    notebookPowerSupply.Close();
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

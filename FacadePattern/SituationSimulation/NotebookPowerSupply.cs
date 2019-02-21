using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SituationSimulation
{
    /// <summary>
    /// 笔记本电脑电源键--相当于外观类
    /// </summary>
    class NotebookPowerSupply
    {
        private OpenPowerSupply _openPowerSupply;
        private ClosePowerSupply _closePowerSupply;
        public NotebookPowerSupply()
        {
            _openPowerSupply = new OpenPowerSupply();
            _closePowerSupply = new ClosePowerSupply();
        }
        public void Open()
        {
            Console.WriteLine("\n--开启电源方法");
            _openPowerSupply.Operation();
        }
        public void Close()
        {
            Console.WriteLine("\n--关闭电源方法");
            _closePowerSupply.Operation();
        }
    }
}

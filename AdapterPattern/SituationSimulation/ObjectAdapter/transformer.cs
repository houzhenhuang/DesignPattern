using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.SituationSimulation.ObjectAdapter
{
    /// <summary>
    /// 变压器
    /// </summary>
    class Transformer :  IComputer
    {
        private NoteBook _noteBook = new NoteBook();
        public void GetVoltage()
        {
            _noteBook.Get220Voltage();
        }
    }
}

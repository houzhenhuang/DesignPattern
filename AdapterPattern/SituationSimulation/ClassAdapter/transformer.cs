using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.SituationSimulation.ClassAdapter
{
    /// <summary>
    /// 变压器
    /// </summary>
    class Transformer : NoteBook, ICompute
    {
        public void GetVoltage()
        {
            this.Get220Voltage();
        }
    }
}

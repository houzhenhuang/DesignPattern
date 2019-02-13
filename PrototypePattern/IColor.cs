using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public interface IColor
    {
        IColor Clone();

        int Red { get; set; }
        int Green { get; set; }
        int Blue { get; set; }
    }
}

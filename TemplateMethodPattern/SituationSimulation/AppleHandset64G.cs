using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.SituationSimulation
{
    class AppleHandset64G : AppleHandset
    {
        public override void MemoryCard()
        {
            Console.WriteLine("插上64G内存卡");
        }
    }
}

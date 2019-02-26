using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.SituationSimulation
{
    class AppleHandset128G : AppleHandset
    {
        public override void MemoryCard()
        {
            Console.WriteLine("插上128G内存卡");
        }
    }
}

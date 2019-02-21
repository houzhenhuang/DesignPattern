using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.SituationSimulation
{
    abstract class HandsetDecorator : Handset
    {
        protected Handset Handset { get; set; }

        public HandsetDecorator(Handset handset)
        {
            this.Handset = handset;
        }
        public override void Operation()
        {
            if (Handset != null)
            {
                Handset.Operation();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.SituationSimulation
{
    /// <summary>
    /// 手机品牌类抽象类
    /// </summary>
    abstract class HandsetBrand
    {
        protected HandsetSoft handsetSoft;

        public void SetHandsetBrand(HandsetSoft handsetSoft)
        {
            this.handsetSoft = handsetSoft;
        }
        public virtual void Run(string name)
        {
            handsetSoft.Run(name);
        }
    }
}

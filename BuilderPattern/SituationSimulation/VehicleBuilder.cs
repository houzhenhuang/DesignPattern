using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.SituationSimulation
{
    /// <summary>
    /// 抽象交通工具部件建造类
    /// </summary>
    abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; set; }
        /// <summary>
        /// 构造车架
        /// </summary>
        public abstract void BuildFrame();
        /// <summary>
        /// 构造改动机
        /// </summary>
        public abstract void BuildEngine();
        /// <summary>
        /// 构造车轮
        /// </summary>
        public abstract void BuildWheels();
        /// <summary>
        /// 构造车门
        /// </summary>
        public abstract void BuildDoors();
    }
}

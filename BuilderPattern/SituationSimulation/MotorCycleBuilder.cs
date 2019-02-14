using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.SituationSimulation
{
    /// <summary>
    /// 摩托车组件建造类
    /// </summary>
    class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            Vehicle = new Vehicle("MotorCycle");
        }
        public override void BuildFrame()
        {
            Vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "MotorCycle Engine 500 cc";
        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "MotorCycle has 2 Wheels";
        }

        public override void BuildDoors()
        {
            Vehicle["doors"] = "MotorCycle has 0 Doors";
        }
        
    }
}

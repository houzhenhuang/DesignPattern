using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.SituationSimulation
{
    /// <summary>
    /// 汽车组件建造类
    /// </summary>
    class CarCycleBuilder : VehicleBuilder
    {
        public CarCycleBuilder()
        {
            Vehicle = new Vehicle("Car");
        }
        public override void BuildFrame()
        {
            Vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "Car Engine 5000 cc";
        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "MotorCycle has 4 Wheels";
        }

        public override void BuildDoors()
        {
            Vehicle["doors"] = "MotorCycle has 4 Doors";
        }

    }
}

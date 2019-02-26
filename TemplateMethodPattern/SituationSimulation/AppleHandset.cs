using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.SituationSimulation
{
    abstract class AppleHandset
    {
        /// <summary>
        /// 手机基架
        /// </summary>
        public void Frame()
        {
            Console.WriteLine("手机基架");
        }
        /// <summary>
        /// 手机摄像头
        /// </summary>
        public void Camera()
        {
            Console.WriteLine("安装手机基架");
        }
        /// <summary>
        /// 手机摄像头
        /// </summary>
        public void Battery()
        {
            Console.WriteLine("安装手机电池");
        }
        /// <summary>
        /// 手机内存卡
        /// </summary>
        public abstract void MemoryCard();
        /// <summary>
        /// 组装手机
        /// </summary>
        public void Assemble()
        {
            Frame();
            Camera();
            Battery();
            MemoryCard();
            Console.WriteLine("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.SituationSimulation.ClassAdapter
{
    /// <summary>
    /// 笔记本电脑类
    /// </summary>
    class NoteBook
    {
        /// <summary>
        /// 获取220V 电压
        /// 系统中已经存在的类，与ITarget接口不兼容，又不好修改这个类
        /// </summary>
        public void Get220Voltage()
        {
            Console.WriteLine("我要使用220V 电压才能正常工作！");
        }
    }
}

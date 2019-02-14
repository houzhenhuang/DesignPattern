using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.SituationSimulation
{
    /// <summary>
    /// 交通工具类
    /// </summary>
    class Vehicle
    {
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public string Name { get; set; }
        public Vehicle(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// 索引
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key]
        {
            get => _parts[key];
            set => _parts[key] = value;
        }

        public void Show()
        {
            Console.WriteLine($"\n------------{this.Name}组件---------------");
            Console.WriteLine($" Frame : {_parts["frame"]}");
            Console.WriteLine($" Engine : {_parts["engine"]}");
            Console.WriteLine($" Wheels: { _parts["wheels"]}");
            Console.WriteLine($" Doors : { _parts["doors"]}");
        }

    }
}

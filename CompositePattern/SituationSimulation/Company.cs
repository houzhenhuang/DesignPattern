using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.SituationSimulation
{
    /// <summary>
    /// 公司抽象类
    /// </summary>
    abstract class Company
    {
        protected string Name { get; set; }
        public Company(string name)
        {
            this.Name = name;
        }

        public abstract void Add(Company company);
        public abstract void Remove(Company company);
        public abstract void Show(int depth);
        public abstract void LineOfDuty();//履行职责
    }
}

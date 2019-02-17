using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.SituationSimulation
{
    /// <summary>
    /// 具体公司类
    /// </summary>
    class ConcreteCompany : Company
    {
        private IList<Company> children = new List<Company>();
        public ConcreteCompany(string name)
            : base(name)
        { }
        public override void Add(Company company)
        {
            children.Add(company);
        }

        public override void Remove(Company company)
        {
            children.Remove(company);
        }
        /// <summary>
        /// 递归显示公司组织架构信息
        /// </summary>
        /// <param name="depth"></param>
        public override void Show(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            foreach (Company company in children)
            {
                company.Show(depth + 2);
            }
        }
        public override void LineOfDuty()
        {
            foreach (Company company in children)
            {
                company.LineOfDuty();
            }
        }
    }
}

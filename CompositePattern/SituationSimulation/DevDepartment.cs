using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.SituationSimulation
{
    /// <summary>
    /// 研发部门类
    /// </summary>
    class DevDepartment : Company
    {
        private IList<Company> children = new List<Company>();
        public DevDepartment(string name)
            : base(name)
        { }
        public override void Add(Company company)
        {
        }

        public override void Remove(Company company)
        {
        }
        /// <summary>
        /// 递归显示研发部门架构信息
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
            Console.WriteLine($"{Name}研发管理");
        }
    }
}

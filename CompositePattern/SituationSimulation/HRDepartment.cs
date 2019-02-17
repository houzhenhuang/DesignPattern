using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.SituationSimulation
{
    /// <summary>
    /// 人力资源部门类
    /// </summary>
    class HRDepartment : Company
    {
        private IList<Company> children = new List<Company>();
        public HRDepartment(string name)
            : base(name)
        { }
        public override void Add(Company company)
        {
        }

        public override void Remove(Company company)
        {
        }
        /// <summary>
        /// 递归显示人力资源部架构信息
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
            Console.WriteLine($"{Name}员工招聘培训管理");
        }
    }
}

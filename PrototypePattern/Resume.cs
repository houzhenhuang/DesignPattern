using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// 简历
    /// </summary>
    public class Resume : ICloneable
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        //public string TimeArea { get; set; }
        //public string Company { get; set; }
        #region 深拷贝
        public WorkExperience WorkExperience { get; set; }
        #endregion
        public Resume(string name)
        {
            this.Name = name;
            this.WorkExperience = new WorkExperience();
        }
        public Resume(WorkExperience work)
        {
            this.WorkExperience = (WorkExperience)work.Clone();
        }
        //设置个人信息
        public void SetPersonalInfo(string sex, int age)
        {
            this.Sex = sex;
            this.Age = age;
        }
        //设置工作经历
        public void SetWorkExperience(string timeArea, string company)
        {
            //this.TimeArea = timeArea;
            //this.Company = company;
            WorkExperience.WorkDate = timeArea;
            WorkExperience.Company = company;
        }
        //显示
        public void Show()
        {
            Console.WriteLine($"姓名：{this.Name} 性别：{this.Sex} 年龄：{this.Age}");
            //Console.WriteLine($"工作经历：{this.TimeArea} {this.Company}");
            Console.WriteLine($"工作经历：{this.WorkExperience.WorkDate} {this.WorkExperience.Company}");
        }

        public object Clone()
        {
            Resume obj = new Resume(this.WorkExperience);
            obj.Name = this.Name;
            obj.Sex = this.Sex;
            obj.Age = this.Age;
            return obj;
        }
    }
}
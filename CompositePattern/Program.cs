using CompositePattern.BasicStructure;
using CompositePattern.SituationSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
    static void Main(string[] args)
    {
        try
        {
            {//BasicStructure
                //初始化一个根节点
                Component root = new Composite("root");
                //添加两个叶节点
                root.Add(new Leaf("Leaf A"));
                root.Add(new Leaf("Leaf B"));

                //实例化一个枝节点，为枝节点添加两个叶节点，然后添加至根节点
                Component comp = new Composite("Composite X");
                comp.Add(new Leaf("Composite XA"));
                comp.Add(new Leaf("Composite XB"));
                root.Add(comp);
                //实例化一个枝节点，为枝节点添加两个叶节点，然后添加至根节点
                Component comp2 = new Composite("Composite Y");
                comp2.Add(new Leaf("Composite YA"));
                comp2.Add(new Leaf("Composite YB"));
                root.Add(comp2);

                root.Add(new Leaf("Leaf C"));
                Leaf leaf = new Leaf("Leaf D");
                root.Add(leaf);
                root.Remove(leaf);

                root.Display(1);
            }
            {//SituationSimulation
                Company company = new ConcreteCompany("华夏企业北京总公司");
                company.Add(new HRDepartment("北京总公司人力资源部"));
                company.Add(new HRDepartment("北京总公司研发部"));

                Company company2 = new ConcreteCompany("华夏企业深圳分公司");
                company2.Add(new HRDepartment("深圳分公司人力资源部"));
                company2.Add(new HRDepartment("深圳分公司研发部"));
                company.Add(company2);

                Company company3 = new ConcreteCompany("华夏企业深圳宝安区分公司");
                company3.Add(new HRDepartment("深圳宝安区分公司人力资源部"));
                company3.Add(new HRDepartment("深圳宝安区分公司研发部"));
                company2.Add(company3);

                Company company4 = new ConcreteCompany("华夏企业深圳龙华区分公司");
                company4.Add(new HRDepartment("深圳龙华区分公司人力资源部"));
                company4.Add(new HRDepartment("深圳龙华区分公司研发部"));
                company2.Add(company4);

                Company company5 = new ConcreteCompany("华夏企业上海分公司");
                company5.Add(new HRDepartment("上海分公司人力资源部"));
                company5.Add(new HRDepartment("上海分公司研发部"));
                company.Add(company5);

                company.Show(1);
                Console.WriteLine("职责：");
                company.LineOfDuty();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
    }
}

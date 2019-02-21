using FlyweightPattern.BasicStructure;
using FlyweightPattern.SituationSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {//BasicStructure
                    int extrinsicState = 22;
                    FlyweightFactory flyweightFactory = new FlyweightFactory();
                    var flyweight = flyweightFactory.GetFlyweight("X");
                    flyweight.Operation(--extrinsicState);

                    flyweight = flyweightFactory.GetFlyweight("Y");
                    flyweight.Operation(--extrinsicState);

                    flyweight = flyweightFactory.GetFlyweight("Z");
                    flyweight.Operation(--extrinsicState);

                    UnSharedConcreteFlyweight uf = new UnSharedConcreteFlyweight();
                    uf.Operation(--extrinsicState);
                }
                {//SituationSimulation
                    WebSiteFactory webSiteFactory = new WebSiteFactory();
                    var fx = webSiteFactory.GetWebSiteCategory("产品展示");
                    fx.Use();
                    var fy = webSiteFactory.GetWebSiteCategory("产品展示");
                    fy.Use();
                    var fz = webSiteFactory.GetWebSiteCategory("产品展示");
                    fz.Use();
                    var fl = webSiteFactory.GetWebSiteCategory("博客");
                    fl.Use();
                    var fm = webSiteFactory.GetWebSiteCategory("博客");
                    fm.Use();
                    var fn = webSiteFactory.GetWebSiteCategory("博客");
                    fn.Use();

                    Console.WriteLine($"网站分类总数为：{webSiteFactory.GetWebSiteCount()}");
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

using AbstractFactory.Factory;
using AbstractFactory.Factory.Gold;
using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BaseFactory goldFactory = new GoldSectsSkillFactory();//金系技能工厂
                ISkill goldMagicAttackSkill = goldFactory.CreateMagicAttackSkill();//创建法术攻击技能类
                goldMagicAttackSkill.ReleaseSkill();//释放技能

                ISkill goldAuxiliarySkill = goldFactory.CreateAuxiliarySkill();//创建辅助技能类
                goldAuxiliarySkill.ReleaseSkill();//释放技能

                BaseFactory woodFactory = new WoodSectsSkillFactory();//木系技能工厂
                ISkill woodMagicAttackSkill = woodFactory.CreateMagicAttackSkill();//创建法术攻击技能类
                woodMagicAttackSkill.ReleaseSkill();//释放技能

                ISkill woodAuxiliarySkill = woodFactory.CreateAuxiliarySkill();//创建辅助技能类
                woodAuxiliarySkill.ReleaseSkill();//释放技能
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory.Gold
{
    /// <summary>
    /// 创建金系门派技能工厂
    /// </summary>
    public class GoldSectsSkillFactory : BaseFactory
    {
        /// <summary>
        /// 创建法攻技能类
        /// </summary>
        /// <returns></returns>
        public override ISkill CreateMagicAttackSkill()
        {
            return new GoldMagicAttackSkill();
        }
        /// <summary>
        /// 创建障碍技能类
        /// </summary>
        /// <returns></returns>
        public override ISkill CreateObstacleSkill()
        {
            return new GoldObstacleSkill();
        }
        /// <summary>
        /// 创建辅助技能类
        /// </summary>
        /// <returns></returns>
        public override ISkill CreateAuxiliarySkill()
        {
            return new GoldAuxiliarySkill();
        }
    }
}

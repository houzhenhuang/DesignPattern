using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 抽象一个技能工厂
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// 法术攻击技能
        /// </summary>
        /// <returns></returns>
        public abstract ISkill CreateMagicAttackSkill();
        /// <summary>
        /// 障碍技能
        /// </summary>
        /// <returns></returns>
        public abstract ISkill CreateObstacleSkill();
        /// <summary>
        /// 辅助技能
        /// </summary>
        /// <returns></returns>
        public abstract ISkill CreateAuxiliarySkill();
    }
}

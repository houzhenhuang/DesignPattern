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
    /// 创建金系门派技能工厂
    /// </summary>
    public class GoldSectsSkillFactory : AbstractFactory
    {
        public override ISkill CreateAuxiliarySkill()
        {
            return new
        }

        public override ISkill CreateMagicAttackSkill()
        {
            throw new NotImplementedException();
        }

        public override ISkill CreateObstacleSkill()
        {
            throw new NotImplementedException();
        }
    }
}

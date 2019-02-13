using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interface
{
    /// <summary>
    /// 门派接口（抽象产品）
    /// </summary>
    public interface ISkill
    {
        /// <summary>
        /// 释放技能
        /// </summary>
        void ReleaseSkill();
    }
}

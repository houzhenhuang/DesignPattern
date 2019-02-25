using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.SituationSimulation
{
    /// <summary>
    /// 环境类
    /// </summary>
    class ChineseEnglishDict
    {
        private  Dictionary<string, string> _dictory = new Dictionary<string, string>();
   
        public ChineseEnglishDict()
        {
            _dictory.Add("this", "这");
            _dictory.Add("is", "是");
            _dictory.Add("an", "一个");
            _dictory.Add("apple", "苹果");
        }

        public string GetEnglish(string value)
        {
            return _dictory[value.ToLower()];
        }
    }
}

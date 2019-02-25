using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.SituationSimulation
{
    /// <summary>
    /// 单词翻译类
    /// </summary>
    class WordExpression : TranslateExpression
    {
        private string _value;
        public WordExpression(string value)
        {
            this._value = value;
        }
        public override string Interpret(ChineseEnglishDict dict)
        {
            return new StringBuilder().Append(dict.GetEnglish(_value)).ToString();
        }
    }
}

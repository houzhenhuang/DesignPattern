using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.SituationSimulation
{
    /// <summary>
    /// 符号翻译类
    /// </summary>
    class SymbolExpression : TranslateExpression
    {
        private string _value;
        public SymbolExpression(string value)
        {
            this._value = value;
        }
        public override string Interpret(ChineseEnglishDict dict)
        {
            switch (_value)
            {
                case ".":
                    return new StringBuilder().Append("。").ToString();
                default: return _value;
            }
        }
    }
}

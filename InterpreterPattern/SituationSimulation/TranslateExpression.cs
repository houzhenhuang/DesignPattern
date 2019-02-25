using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.SituationSimulation
{
    /// <summary>
    /// 翻译抽象类
    /// </summary>
    abstract class TranslateExpression
    {
        public abstract string Interpret(ChineseEnglishDict context);
    }
}

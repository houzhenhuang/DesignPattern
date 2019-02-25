using InterpreterPattern.BasicStructure;
using InterpreterPattern.SituationSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {//BasicStructure
                    Context context = new Context();
                    IList<AbstractExpression> list = new List<AbstractExpression>();
                    list.Add(new TerminalExpression());
                    list.Add(new NonterminalExpression());
                    list.Add(new TerminalExpression());
                    list.Add(new TerminalExpression());

                    foreach (var item in list)
                    {
                        item.Interpret(context);
                    }
                }
                {//SituationSimulation
                    IList<TranslateExpression> list = new List<TranslateExpression>();
                    string english = "This is an apple.";
                    var elements = english.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var element in elements)
                    {
                        var words = element.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var word in words)
                        {
                            list.Add(new WordExpression(word));
                        }
                        list.Add(new SymbolExpression("."));
                    }
                    ChineseEnglishDict dict = new ChineseEnglishDict();
                    string result = "";
                    foreach (var item in list)
                    {
                        result += item.Interpret(dict);
                    }
                    Console.WriteLine(english + "翻译后：" + result);
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

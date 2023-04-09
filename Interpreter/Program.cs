using System.Xml.XPath;
using System.Linq.Expressions;
namespace Interpreter{

    public class Program{
        static void Main(string[] args){
            TerminalExpression number1 = new TerminalExpression(10);
            TerminalExpression number2 = new TerminalExpression(20);

            NonTerminalExpression expression = new NonTerminalExpression(number1, number2);

            int result = expression.Interprete();

            Console.WriteLine($"Result is: {result}");
            

        }
    }
}
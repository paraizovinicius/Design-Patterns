
using System;
namespace Strategy{
    
    public class Program{
        static void Main(string[] args){


            var cart = new StrategyCalculation(new Strategy1());
            decimal total = cart.CalculateTotal(100);

            var cart2 = new StrategyCalculation(new Strategy2());
            decimal total2 = cart2.CalculateTotal(100);

            
            Console.WriteLine($"\nPrice in standart discount: {total} \nPrice in Black Friday discount: {total2}");
        }
    }
}
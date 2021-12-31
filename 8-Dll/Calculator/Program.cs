using System;
using Calculator;

namespace CalculatorReal
{

    class Program
    {
        static void Main(string[] args)
        {
            decimal x = 110;
            decimal y = 200;
            Console.WriteLine(Calculate.Add(x,y));
            Console.WriteLine(Calculate.Minus(x,y));
            Console.WriteLine(Calculate.Multiply(x,y));
            Console.WriteLine(Calculate.Divide(x,y));

        }
    }
}

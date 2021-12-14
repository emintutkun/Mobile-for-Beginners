using System;

namespace Scope2
{
    class Program
    {
        static int x = 0;
        static void Main(string[] args)
        {
            x = 100;
            Console.WriteLine("First value of X: " + x);
            DoubleIT(x);
            Console.WriteLine("Last value of X: " + x);
        }

        private static void DoubleIT(int x)
        {
            x *= 2;
            Console.WriteLine("Value of X in Method: " + x);
        }
    }
}

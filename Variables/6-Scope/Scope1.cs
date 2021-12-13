using System;

namespace Scope1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine("First value of X: " + x);
            DoubleIT(x);
            Console.WriteLine("Last value of X: " + x);
        }

        private static void DoubleIT(int a)
        {
            a *= 2;
            Console.WriteLine("Value of A in Method: " + a);
        }
    }
}

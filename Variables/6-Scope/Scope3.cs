using System;

namespace Scope_3
{
    class Program
    {
       static int x = 0;
        static void Main(string[] args)
        {
            int x = 100; //try replace integer
            Console.WriteLine("First value of X: " + x);
            DoubleIT();
            Console.WriteLine("Last value of X: " + x);
        }

        private static void DoubleIT()
        {
            x *= 2;
            Console.WriteLine("Value of X in Method: " + x);
        }
    }
}

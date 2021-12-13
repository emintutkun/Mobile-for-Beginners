using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 25, 7, 66 };
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());

            string[] month = { "January", "February", "March","April" };
            Console.WriteLine(month[0]);
        }
    }
}

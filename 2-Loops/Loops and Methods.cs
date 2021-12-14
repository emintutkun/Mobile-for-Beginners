using System;

namespace Loops
{
    class Program
    {
        static int[] numbers = { 10, 15, 72, 37, 48 };
        static int counter = 0;
        static int total = 0;

        static void Main(string[] args)
        {
            
            TitleWriter("For Loops");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }
           TotalWriter(total);

            TitleWriter("Do While Loops");
            do
            {
                Console.WriteLine(numbers[counter]);
                total += numbers[counter];
                counter = counter + 1;
            }      
            while (counter<numbers.Length);
            TotalWriter(total);
            //reset counter
            TitleWriter("While Loops");
            while (counter<numbers.Length)
            {
                total += numbers[counter];
                Console.WriteLine(numbers[counter]);
                counter = counter + 1;
            }
            TotalWriter(total);
            TitleWriter("Foreach Loop");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
                total += item;
            }
            TotalWriter(total);
        }
        private static void TitleWriter(string title)
        {
            total = 0;
            counter = 0;
            Console.WriteLine("**************");
            Console.WriteLine(title);
            Console.WriteLine("**************");
        }
        private static void TotalWriter(int total)
        {
            Console.WriteLine("**************");
            Console.WriteLine("Toplam:" + total);
            Console.WriteLine("**************");
        }
    }
}

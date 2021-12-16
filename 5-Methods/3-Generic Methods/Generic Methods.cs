using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Array");
            Console.WriteLine("2-Array");
            Console.WriteLine("3-Array List");
            Console.WriteLine("4-Generic List 1");
            Console.WriteLine("5-Generic List 2");
            Console.WriteLine("6-Generic List 3");
            Console.WriteLine("7-Generic List 4");

            Console.WriteLine("Please choose anyone");
            string choose = Console.ReadLine();
            Choose(choose);
        }
        private static void Choose(string choose1)
        {
            if (choose1 == "1")
            {
                Aray1();
            }
            else if (choose1 == "2")
            {
                Aray2();
            }
            else if (choose1 == "3")
            {
                AList0();
            }
            else if (choose1=="4")
            {
                generic1();
            }
            else if (choose1=="5")
            {
                generic2();
            }
            else if (choose1=="6")
            {
                generic3();
            }
            else if (choose1 == "7")
            {
                generic4();
            }
            Main(null);
        }

        private static void generic4()
        {
            List<ConsoleColor> color = new List<ConsoleColor>();
            color.Add(ConsoleColor.DarkRed);
            color.Add(ConsoleColor.Yellow);
            color.Add(ConsoleColor.DarkBlue);
            color.Add(ConsoleColor.DarkGreen);
            color.Add(ConsoleColor.Magenta);

            foreach (var item in color)
            {
                Console.BackgroundColor = item;
                Console.WriteLine(item);
            }
        }

        private static void generic3()
        {
            List<object> flex = new List<object>();
            flex.Add("Apple");
            flex.Add("Melon");
            flex.Add("Watermelon");
            flex.Add(100);
            foreach (var item in flex)
            {
                Console.WriteLine(item);
            }
        }

        private static void generic2()
        {
            List<string> char35 = new List<string>();
            char35.Add("Apple");
            char35.Add("Melon");
            char35.Add("Watermelon");
            foreach (var item in char35)
            {
                Console.WriteLine(item);
            }
        }

        private static void generic1()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        private static void AList0()
        {
            Console.WriteLine("Alist - 1");
            ArrayList alist = new ArrayList();
            alist.Add(10);
            alist.Add(20);
            alist.Add("Apple");
            alist.Add("January");
            alist.Remove("January");
            alist.Remove(1);
            foreach (var item in alist)
            {
                Console.WriteLine(item);
            }
        }

        private static void Aray2()
        {
            Console.WriteLine("Array - 2");
            string[] fruits = { "Apple", "Melon", "Watermelon" };
        foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array2");
        }

        private static void Aray1()
        {
            int[] numbers = { 10, 20, 30, 40 };
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array");
        }
    }
}

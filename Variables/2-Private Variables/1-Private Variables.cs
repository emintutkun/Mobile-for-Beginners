using System;

namespace Ozel
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor fgcolor = ConsoleColor.DarkBlue;
            ConsoleColor bgcolor = ConsoleColor.Yellow;
            Console.ForegroundColor = fgcolor;
            Console.BackgroundColor = bgcolor;
    
            int x = 100;
            decimal y = 100.25m;
            bool EH = true;
            string name = "name";
            x *= 2;
            Console.WriteLine("Int :" + x);
            Console.WriteLine("Decimal:" + y);
            Console.WriteLine("Bool:" + EH);
            Console.WriteLine("String:" + name);
        }
    }

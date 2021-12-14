using System;

namespace VarTip
{
    class Program
    {
        static void Main(string[] args)
        {
            var fgcolor = ConsoleColor.DarkBlue;
            ConsoleColor bgcolor = ConsoleColor.Yellow;
            Console.ForegroundColor = fgcolor;
            Console.BackgroundColor = bgcolor;

            var x = 100;
            var y = 100.25m;
            var EH = true;
            var name = "name";
            x *= 2;
            Console.WriteLine("Int :" + x);
            Console.WriteLine("Decimal:" + y);
            Console.WriteLine("Bool:" + EH);
            Console.WriteLine("String:" + name);
        }
    }
}

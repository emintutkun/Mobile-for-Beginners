using System;

namespace objectTip
{
    class Program
    {
        static void Main(string[] args)
        {
            object fgcolor = ConsoleColor.DarkBlue;
            ConsoleColor bgcolor = ConsoleColor.Yellow;
            Console.ForegroundColor = (ConsoleColor)fgcolor;
            Console.BackgroundColor = bgcolor;

            object x = 100;
            var y = 100.25m;
            object EH = true;
            var name = "name";
            x =(int) x*2;
            Console.WriteLine("Int :" + x);
            Console.WriteLine("Decimal:" + y);
            Console.WriteLine("Bool:" + EH);
            Console.WriteLine("String:" + name);
        }
    }
}

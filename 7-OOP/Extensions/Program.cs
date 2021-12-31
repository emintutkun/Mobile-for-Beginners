using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Emin";
            DateTime today = DateTime.Now;
            Console.WriteLine(name.FirstLetterBig());
            Console.WriteLine(today.ToJulian());

        }
    }
}

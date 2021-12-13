using System;

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Name";
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());

            string str = "Noise";
            Console.WriteLine(str.Contains("se"));
            Console.WriteLine(str.Contains("nom"));

            Console.WriteLine(str.GetType());

            Console.WriteLine(str.IndexOf("i"));

            Console.WriteLine(str.Replace('o','ö'));

            object a = "50";

            string name2 = "        Name******";
            Console.WriteLine(name2.Trim());
            Console.WriteLine(name2.TrimEnd('*'));
            Console.WriteLine(name2.TrimStart());
        }
    }
}

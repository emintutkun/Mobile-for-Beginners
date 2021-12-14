using System;

namespace Donusumler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert

            int x = 100;
            string y = "200";
            int total = x + Convert.ToInt32 (y);
            
            Console.WriteLine("Total: " + total);

            string a = "100";
            string b = "200";
            var total2 = a + b;

            Console.WriteLine("Total 2: " + total2);

            //cast

            object a1 = 100;
            int b1 = 200;
            int top3 = (int)a1 + b1;

            Console.WriteLine("Total 3: " + total3 );

            long Identity = 78945612378;
            string name = "Name";
            string surname = "Surname";

            //Methodical: In number and character collection, number is automatically converted to string.

            string info = " Identity:" + Identity.ToString() + " Name:" + name + " Surname:" + surname;
            Console.WriteLine("Info: "+ info);
        }
    }
}

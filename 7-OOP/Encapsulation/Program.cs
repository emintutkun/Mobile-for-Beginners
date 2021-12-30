using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Id = 1;
            c.Name = "Emin";
            c.Surname = "Tutkun";
            c.CardNo1 = "12347014";
            Console.WriteLine($"{c.Name}{c.Surname}");
            Console.WriteLine($"Credit Card:{ c.CardNo1}");

            Staff s = new Staff();
            s.Id = 1;
            s.Name1 = "Recep";
            s.Surname1 = "Recepow";
            Console.WriteLine($"{s.Name1}{s.Surname1}");

        }
    }
}

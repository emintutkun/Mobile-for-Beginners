using System;

namespace Calculator
{
    class Program
    {
        static decimal s1 = 0;
        static decimal s2 = 0;
        static void Main(string[] args)
        {
            decimal s1 = convert("First Number:");
            decimal s2 = convert("Secong Number:");
            string procode = Process();
            decimal result = Calculate(procode,s1,s2);

            Write(result);
        }

        private static void Write(decimal result)
        {
            if (result==0&&s2==0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("Result:" + result);
            }Main(null);
        }

        private static decimal Calculate(string procode,decimal s1,decimal s2)
        {
            decimal result = 0;

            if (procode == "+")
            {
                result = Plus(s1, s2);
            }
            else if (procode == "-")
            {
                result = Minus(s1, s2);
            }
            else if (procode == "*")
            {
                result = Multiply(s1, s2);
            }
            else if (procode == "/")
            {
                if (s2!=0)
                {
                    result = Divide(s1, s2);
                }
            }
            return result;
        }

        private static decimal Divide(decimal s1, decimal s2)
        {
            try
            {
                return s1 / s2;

            }
            catch (Exception)
            {
                Console.WriteLine("Second number cannot be zero!!!");
                Main(null);
                return 1;
            }
        }

        private static decimal Multiply(decimal s1, decimal s2)
        {
            return s1 * s2;
        }

        private static decimal Minus(decimal s1, decimal s2)
        {
            return s1 - s2;
        }

        private static decimal Plus(decimal s1, decimal s2)
        {
            return s1 + s2;
        }

        private static string Process()
        {
            Console.WriteLine("Tell us process code please + - * /");
            string prcode = Console.ReadLine();

            if (prcode == "+" || prcode == "-" || prcode == "*" || prcode == "/")
            {
                return prcode;
            }
            else
            {
                Console.WriteLine("Wrong Process Code!!!");
                return Process();

            }
        }

        private static decimal convert(string txt)
        {
            try
            {
                Console.WriteLine(txt);
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Use Numbers Please!");
                return convert(txt);
            }
        }
    }
}

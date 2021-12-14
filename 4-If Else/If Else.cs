using System;

namespace If_Else_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name;
            int age = 0;
            name = Console.ReadLine();            
            Console.WriteLine("Hello " + name + " What's your age?");
            
            age = Convert.ToInt32 (Console.ReadLine());

            if (age>=18)
            {
                Console.WriteLine($"{name} You can come in");
            }
            else
                Console.WriteLine(name + " Please understand me. " + "You are young for here. " + "You cant come in, Literally you can't!!!" + " Dont break me :(");
            Console.ReadLine();
            Main(null);
        }
    }
}

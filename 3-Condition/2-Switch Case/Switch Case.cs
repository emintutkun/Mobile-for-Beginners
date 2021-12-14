using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // try to ex.message
                //decimal b = 0.0m;
                //decimal a = 10 / b;
                Console.WriteLine("Which day is today");
                int day = Convert.ToInt32(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("You write wrong day.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Main(null);
                throw;
            }
            

            
            
        }
    }
}

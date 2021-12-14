using System;

namespace Addition_Seasons
{
    class Program
    {
        static void Main()
        {
            try
            {
                int months;
                string sphere;

                Console.WriteLine("What month are you in?(Number)");
                months = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What sphere are you in?(North=n/South=s)");
                sphere = Console.ReadLine();

                if (sphere == "n")
                {
                    switch (months)
                    {
                        case 1:
                            Console.WriteLine("The season is Winter");
                            break;
                        case 2:
                            Console.WriteLine("The season is Winter");
                            break;
                        case 3:
                            Console.WriteLine("The season is Spring");
                            break;
                        case 4:
                            Console.WriteLine("The season is Spring");
                            break;
                        case 5:
                            Console.WriteLine("The season is Spring");
                            break;
                        case 6:
                            Console.WriteLine("The season is Summer");
                            break;
                        case 7:
                            Console.WriteLine("The season is Summer");
                            break;
                        case 8:
                            Console.WriteLine("The season is Summer");
                            break;
                        case 9:
                            Console.WriteLine("The season is Autumn");
                            break;
                        case 10:
                            Console.WriteLine("The season is Autumn");
                            break;
                        case 11:
                            Console.WriteLine("The season is Autumn");
                            break;
                        case 12:
                            Console.WriteLine("The season is Winter");
                            break;

                        default:
                            Console.WriteLine("Wrong number!!!");
                            break;       
                    }                    
                }
                else if (sphere == "s")
                {
                    switch (months)
                    {
                        case 1:
                            Console.WriteLine("The season is Summer");
                            break;
                        case 2:
                            Console.WriteLine("The season is Summer");
                            break;
                        case 3:
                            Console.WriteLine("The season is Autumn");
                            break;
                        case 4:
                            Console.WriteLine("The season is Autumn");
                            break;
                        case 5:
                            Console.WriteLine("The season is Autumn");
                            break;
                        case 6:
                            Console.WriteLine("The season is Winter");
                            break;
                        case 7:
                            Console.WriteLine("The season is Winter");
                            break;
                        case 8:
                            Console.WriteLine("The season is Winter");
                            break;
                        case 9:
                            Console.WriteLine("The season is Spring");
                            break;
                        case 10:
                            Console.WriteLine("The season is Spring");
                            break;
                        case 11:
                            Console.WriteLine("The season is Spring");
                            break;
                        case 12:
                            Console.WriteLine("The season is Summer");
                            break;

                        default:
                            Console.WriteLine("Wrong Sphere");
                            break;
                    }
                }else
                {
                    Console.WriteLine("Go to hospital bro, you need to have a brain.");
                    Environment.Exit(0);
                }
                    

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            Main();
        }
    }
}

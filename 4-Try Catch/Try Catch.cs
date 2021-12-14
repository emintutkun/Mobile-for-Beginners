using System;

namespace Catch_Error
{
    class Program
    {
       static int result = 0;
        static void Main()
        {
            int s1 = 0;
            int s2 = 0;
            string oc;//Operation Code
            
            try
            {

                Console.WriteLine("First Number:");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second Number:");
                s2 = Convert.ToInt32(Console.ReadLine());
                               
                Console.WriteLine("Operation Code: + - * /");
                oc = (Console.ReadLine());
               
                switch (oc)
                {
                    case "+":
                        result = s1 + s2;
                        ResultWriter(result);
                        break;
                    case "-":
                        result = s1 - s2;
                        ResultWriter(result);
                        break;
                    case "*":
                        result = s1 * s2;
                        ResultWriter(result);
                        break;
                    case "/":
                        result = s1 / s2;
                        ResultWriter(result);
                        break;

                    default:
                        Console.WriteLine("Wrong Operation Code");
                        break;
                }
                Main();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main();
            }
        }
        private static void ResultWriter(int result)
        {
            
            Console.WriteLine("Result:" + result);
            
        }
    }
}

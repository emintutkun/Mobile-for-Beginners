using System;

namespace HowMuchMoneyIHave
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How much Turkish Liras I have?");
                int tl = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How much Dollars I have?");
                int dolar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How much Euros I have?");
                int euro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the exchange rate for Dollars?");
                int rate_D = Convert.ToInt32(Console.ReadLine());
                int dolartlprofit = dolar * rate_D;
                Console.WriteLine("What is the exchange rate for Euros?");
                int rate_E = Convert.ToInt32(Console.ReadLine());
                int eurotlprofit = euro * rate_E;
                int totalmoney = tl + dolartlprofit + eurotlprofit;
                Console.WriteLine("Total Money:" + totalmoney);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(null);
            }
           
        }
    }
}

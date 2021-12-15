using System;

namespace HowMuchMoney_2nd_Turn
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
                DolarCalculate(dolar,tl);
                //EuroCalculate(euro, tl);
                //int totalmoney = tl + dolartlprofit + eurotlprofit;
                //Console.WriteLine("Total Money:" + totalmoney);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(null);
            }
        }
        private static void DolarCalculate(int dolar,int tl)
        {
            Console.WriteLine("What is the exchange rate for Dollars?");
            int rate_D = Convert.ToInt32(Console.ReadLine());
            int dolartlprofit = dolar * rate_D;
            int totalmoney = tl + dolartlprofit;
            Console.WriteLine("Total Money:" + totalmoney);
        }
        private static void EuroCalculate(int euro, int tl)
        {
            Console.WriteLine("What is the exchange rate for Euros?");
            int rate_E = Convert.ToInt32(Console.ReadLine());
            int dolartlprofit = euro * rate_E;
            int totalmoney = tl + dolartlprofit;
            Console.WriteLine("Total Money:" + totalmoney);

        }
    }
}

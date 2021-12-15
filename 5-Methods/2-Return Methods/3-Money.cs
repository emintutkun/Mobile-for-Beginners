using System;

namespace HowMuchMoney3rdTurn
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tl = ConvertDecimal("How much Tl you have?");

            decimal dollar = ConvertDecimal("How much Dollars you have?");
            //decimal dollarTlProfit = RateCalculate(dollar);
            decimal euro = ConvertDecimal("How much Euro you have ?");
            //decimal euroTlProfit = RateCalculate(euro);
            //decimal total = dollarTlProfit + euroTlProfit + tl;
            decimal total = RateCalculate(dollar) + RateCalculate(euro) + tl;
            Yazdir(total);
        }

        private static void Yazdir(decimal total)
        {
            Console.WriteLine("Total Money:" + total);
        }

        private static decimal RateCalculate(decimal forex)
        {
            try
            {
                Console.WriteLine("Exchange Rate:");
                decimal rate = Convert.ToDecimal(Console.ReadLine());
                return rate * forex;
            }
            catch (Exception)
            {

                Console.WriteLine("Use numbers please!!!");
                
                return RateCalculate(forex);
            }
            
        }

        static decimal ConvertDecimal(string txt)
        {
            try
            {
                Console.WriteLine(txt);

                return Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Use numbers please!!!");
                return ConvertDecimal(txt);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class MyExtensions
    {
        public static string FirstLetterBig(this String var)
        {
            return var.Substring(0,1).ToUpper()+var.Substring(1);
        }
        public static int ToJulian(this DateTime d)
        {
            int year = d.Year*10000;
            int month = d.Month*100;
            int day = d.Day;
            year = year + month + day;

            return year;
        }
        /*public static DateTime ToDate(this int x)
        {
            homework :)
            return ;
        
        }*/
    }
}

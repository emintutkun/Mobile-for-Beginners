using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            PropertyInfo[] prop = typeof(Personel).GetProperties();
            foreach (var item in prop)
            {
                Console.WriteLine(item.Name + " ");
            }
            
            MethodInfo[] methods = typeof(Personel).GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}

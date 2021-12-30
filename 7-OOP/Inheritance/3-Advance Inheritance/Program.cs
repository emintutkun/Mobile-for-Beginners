using Advance_Inheritance.Classes;
using System;

namespace Advance_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Emin";
            s.Surname = "Tutkun";
            s.Department = "Computer Engineer";
            s.Highroad = "Ayvansaray County";
            s.Sex = 'E';
            s.BornDate = Convert.ToDateTime("03/17/1998");
            s.Id = 1;
            s.County = "Bagcilar";
            s.City = "Istanbul";
            s.DoorNumber = 19;
            s.Street = "541";
            Console.WriteLine(s.GetTitle());
            Console.WriteLine(s.GetAge());

            foreach (var item in s.GetAddress())
            {
                Console.WriteLine(item);
            }
        }
    }
}

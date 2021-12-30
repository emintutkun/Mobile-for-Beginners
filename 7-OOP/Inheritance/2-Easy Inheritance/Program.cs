using System;

namespace Easy_Inheritance_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student();
            s.Name = "Emin";
            s.Surname = "Tutkun";
            s.Department = "Computer Engineer";
            s.Address.Highroad = "Ayvansaray County";
            s.Sex = 'E';
            s.BornDate = Convert.ToDateTime("03/17/1998");
            s.Id = 1;
            s.Address.County = "Bagcilar";
            s.Address.City = "Istanbul";
            s.Address.DoorNumber = 19;
            s.Address.Street = "541";
            Console.WriteLine(s.GetTitle());
            Console.WriteLine(s.GetAge());

            foreach (var item in s.GetAddress())
            {
                Console.WriteLine(item);
            }
        }
    }
}

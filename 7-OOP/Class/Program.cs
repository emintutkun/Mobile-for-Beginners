 using System;

namespace Class
{
    class Program
    {
        static void Main (string[] args)
        {
            int x;
            Student o1 = new Student();
            o1.Id = 1;
            o1.Name = "Emin";
            o1.Surname = "Tutkun";

            Student o2 = new Student();
            o2.Id = 1;
            o2.Name = "Semi";
            o2.Surname = "Erden";
            Console.WriteLine(o1.Name+ " "+ o1.Surname);
        }
    }
}

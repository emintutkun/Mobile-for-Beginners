using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    class Program
    {
        static List<Student> slist = new List<Student>();

        static void Main(string[] args)
        {
            Fill();

        }

        private static void Fill()
        {
            int sex;
            int age;
            for (int i = 1; i <= 20; i++)
            {
                Student s = new Student();
                s.Name = FakeData.NameData.GetFirstName();
                s.Street = FakeData.PlaceData.GetStreetName();
                sex = FakeData.NumberData.GetNumber(0,1);
                if (sex==0)
                {
                    s.Sex = 'E';
                }
                else
                {
                    s.Sex = 'K';
                }
                age = FakeData.NumberData.GetNumber(1, 99);
                s.BornDate = DateTime.Now.AddYears(age* -1);
                s.Id = i;
                s.County = FakeData.PlaceData.GetCounty();
                s.DoorNumber = FakeData.NumberData.GetNumber(0, 99);
                s.Surname = FakeData.NameData.GetSurname();
                slist.Add(s);

            }
            Console.WriteLine("Id   Name    Surname");
            Console.WriteLine("====================");
            foreach (var item in slist)
            {
                Console.WriteLine(item.Id + " "+ item.Name + " "+ item.Surname);
            }
            Console.ReadLine();
        }
    }
}

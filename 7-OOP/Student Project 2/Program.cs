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
        static int chosenId;
        static Student chosenStudent;

        static void Main(string[] args)
        {
            Menu();
        }
        private static void Menu()
        {
            Console.WriteLine("1-Getting Data");
            Console.WriteLine("2-Show Data");
            Console.WriteLine("3-New Data");
            Console.WriteLine("4-Delete Data");
            Console.WriteLine("5-Update Data");
            Console.WriteLine("Please Getting Data First");
            
            try
            {
                int chose = Convert.ToInt32(Console.ReadLine());
                if (chose == 1)
                {
                    Fill();
                    Write(slist);
                }
                else if (chose == 2)
                {
                    Detail();
                }
                else if (chose == 3)
                {
                    New();
                }
                else if (chose == 4)
                {
                    Delete();
                }
                else if (chose == 5)
                {
                    Update();
                }
                else
                {
                    Console.WriteLine("Wrong Entry, Please Try Again");
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            
            Menu();
        }
        //1
        private static void Fill()
        {
            int sex;
            int age;
            for (int i = 1; i <= 20; i++)
            {
                Student s = new Student();
                s.Name = FakeData.NameData.GetFirstName();
                s.Street = FakeData.PlaceData.GetStreetName();
                sex = FakeData.NumberData.GetNumber(0, 2);
                
                if (sex == 0)
                {
                    s.Sex = 'E';
                }
                else if (sex==1)
                {
                    s.Sex = 'K';
                }               
                age = FakeData.NumberData.GetNumber(1, 99);
                s.BornDate = DateTime.Now.AddYears(age * -1);
                s.Id = i;
                s.County = FakeData.PlaceData.GetCounty();
                s.DoorNumber = FakeData.NumberData.GetNumber(0, 99);
                s.Surname = FakeData.NameData.GetSurname();
                s.City = FakeData.PlaceData.GetCity();
                slist.Add(s);
            }   
        }     
        //2
        private static void Detail()
        {
            Fill();
            Console.WriteLine("Id?");
            chosenId = Convert.ToInt32(Console.ReadLine());
            chosenStudent = slist.Find(x => x.Id == chosenId);
            sex2();
            Console.WriteLine("BornDate:" + chosenStudent.BornDate);
            GetAge();
            GetAddress();
            Console.WriteLine(chosenStudent.getAddress2() +"\n");
            chosenStudent.getAddress3();
        }
        //3
        private static void New()
        {
            throw new NotImplementedException();
        }
        //4
        private static void Delete()
        {
            throw new NotImplementedException();
        }
        //5
        private static void Update()
        {
            throw new NotImplementedException();
        }

        private static void sex2()
        {
            if (chosenStudent.Sex == 'E')
            {
                Console.WriteLine("Mr:" + chosenStudent.Surname);
            }
            else if (chosenStudent.Sex == 'K')
            {
                Console.WriteLine("Ms:" + chosenStudent.Surname);
            }
        }
        private static void GetAge()
        {
            DateTime today = DateTime.Now;
            int GetAge = today.Year - chosenStudent.BornDate.Year;
            Console.WriteLine(GetAge);
        }
        private static void GetAddress()
        {
            Console.WriteLine("City:" + chosenStudent.City);
            Console.WriteLine("County:" + chosenStudent.County);
            Console.WriteLine("Street:" + chosenStudent.Street);
            Console.WriteLine("Door Number:" + chosenStudent.DoorNumber);
        }
        private static void Write(List<Student> slist)
        {
            Console.WriteLine("Id    Name     Surname");
            Console.WriteLine("======================");
            foreach (var item in slist)
            {
                Console.WriteLine(item.Id + "   " + item.Name + "   " + item.Surname + "   " + item.Sex);
            }
            Console.ReadLine();
        }
    }
}

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
            Console.WriteLine("6-Close");
            Console.WriteLine("Please Getting Data First");

            try
            {
                int chose = Convert.ToInt32(Console.ReadLine());
                Chosee(chose);


            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.ReadLine();
                Console.Clear();
                Main(null);
            }

            Menu();
        }

        private static void Chosee(int chose)
        {
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
            else if (chose == 6)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong Entry, Please Try Again");
                Console.ReadLine();
                Console.Clear();
                Main(null);
            }
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
                else if (sex == 1)
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
                s.Salary = FakeData.NumberData.GetNumber(4200, 9999);
                slist.Add(s);
                {
                    Write(slist);
                }
            }
        }
        //2
        private static void Detail()
        {
            Fill();
            Console.WriteLine("Id?");
            chosenId = Convert.ToInt32(Console.ReadLine());
            chosenStudent = slist.Find(x => x.Id == chosenId);
            if (chosenStudent.Sex == 'E')
            {
                Console.WriteLine(chosenStudent.GetTitle() + "\n" + chosenStudent.getAge() + "\n");
                foreach (var item in chosenStudent.getAddress())
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                Menu();
            }
            else if (chosenStudent.Sex == 'K')
            {
                Console.WriteLine(chosenStudent.GetTitle() + "\n" + chosenStudent.getAge() + "\n");
                foreach (var item in chosenStudent.getAddress())
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                Menu();
            }

            Console.WriteLine(chosenStudent.getAddress2() + "\n");
            chosenStudent.getAddress3();
        }
        //3
        private static void New()
        {

        }
        //4
        private static void Delete()
        {
            Console.WriteLine("Id?");
            chosenId = Convert.ToInt32(Console.ReadLine());
            chosenStudent = slist.Find(x => x.Id == chosenId);
            slist.Remove(chosenStudent);
            Write(slist);
        }
        //5
        private static void Update()
        {
            throw new NotImplementedException();
        }

        private static void Write(List<Student> slist)
        {
            Console.WriteLine("Id    Name     Surname");
            Console.WriteLine("======================");
            foreach (var item in slist)
            {
                Console.WriteLine(item.Id + "   " + item.Name + "   " + item.Surname);
            }
            TotalWrite(slist);
            Console.ReadLine();
            Menu();
        }
        //Total people and total salary
        private static void TotalWrite(List<Student> slist)
        {
            int num_student = 0;
            int num_men = 0;
            int num_women = 0;
            int totalsalary = 0;
            int totalsalary_men = 0;
            int totalsalary_women = 0;
            foreach (var item in slist)
            {
                num_student += 1;
                totalsalary += item.Salary;
                if (item.Sex == 'E')
                {
                    num_men++;
                    totalsalary_men += item.Salary;
                }
                else
                {
                    num_women++;
                    totalsalary_women += item.Salary;
                }
            }
            Console.WriteLine($"\n Number of Men: {num_men}\n" + $"Total salary of Men: {totalsalary_men}\n" 
                + $"Number of Women:{num_women}\n" + $"Total salary of Women: {totalsalary_women}\n" 
                + $"Number of Student:{num_student}\n" + $"Total salary:{totalsalary}");
            Console.WriteLine("");
        }
        //Total people and total salary 2
        private static void TotalWrite2(List<Student> slist)
        {
            int num_student = 0;
            int num_men = 0;
            int num_women = 0;
            int totalsalary = 0;
            int totalsalary_men = 0;
            int totalsalary_women = 0;
            num_student = slist.Count;
            num_men = slist.Where(x => x.Sex == 'E').Count();
            num_women = slist.Where(x => x.Sex == 'K').Count();
            totalsalary = slist.Sum(x => x.Salary);
            totalsalary_men = slist.Where(x => x.Sex == 'E').Sum(x=>x.Salary);
            totalsalary_women = slist.Where(x => x.Sex == 'K').Sum(x => x.Salary);
            Console.WriteLine($"Number of Men: {num_men}"+ $"Total salary of Men: {totalsalary_men}"
                + $"Number of Women: {num_women}" + $"Total salary of Women: {totalsalary_women}"
                + $"Number of Student: {num_student}" + $"Total salary: {totalsalary}");
            Console.WriteLine($"Average Men Salary: " + slist.Where(x=>x.Sex == 'E').Average(x=>x.Salary));
            Console.WriteLine($"Average Women Salary: " + slist.Where(x => x.Sex == 'K').Average(x => x.Salary));
        }

        private Student ChoseStudent()
        {
            Console.WriteLine("Id?");
            chosenId = Convert.ToInt32(Console.ReadLine());
            return slist.Find(x => x.Id == chosenId);
        }
    }
}

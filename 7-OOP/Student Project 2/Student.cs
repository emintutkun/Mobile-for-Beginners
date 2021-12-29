using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public char Sex { get; set; }
        public DateTime BornDate { get; set; }
        public string Street { get; set; }
        public int DoorNumber { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public int Salary { get; set; }
        public string GetTitle()
        {
            if (Sex == 'E')
            {
                return "Mr:" + Surname;
            }
            else 
            {
                return "Ms:" + Surname;
            }
        }
        public int getAge()
        {
            DateTime today = DateTime.Now;
            int Age = today.Year - BornDate.Year;
            DateTime BornDay = BornDate.AddYears(Age);
            
            
            if (BornDate < today)
            {
                Age = Age + 1;
            }
            return Age;
        }
        public List<string> getAddress()
        {
            List<string> adr = new List<string>();
            adr.Add(City);
            adr.Add(County);
            adr.Add(Street);
            adr.Add(DoorNumber.ToString());
            return adr;
        }
        public string getAddress2()
        {
            return $"   City: { City}\n No { DoorNumber}\n" + $"{County + City}";
        }
        public void getAddress3()
        {
            string[] adr = { Street, DoorNumber.ToString(), County + "%" + City };
            foreach (var item in adr)
            {
                Console.WriteLine(item);
            }
        }
    }
}

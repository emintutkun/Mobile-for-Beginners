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

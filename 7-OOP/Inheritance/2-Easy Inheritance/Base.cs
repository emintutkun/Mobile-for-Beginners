using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Easy_Inheritance_2
{
    abstract public class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }
        public char Sex { get; set; }
        public DateTime BornDate { get; set; }
        public Base()
        {
            Address = new Address();
        }
        public string GetTitle()
        {
            if (Sex == 'E')
            {
                return $"Mr {Name} {Surname}";
            }
            else
            {
                return $"Ms {Name} {Surname}";
            }
        }
        
        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - BornDate.Year;
            DateTime BornDay = BornDate.AddYears(age);
            if (BornDay < today)
            {
                age += 1;
            }
            return age;

        }
        public List<string> GetAddress()
        {
            List<string> address = new List<string>();
            address.Add(Address.Highroad);
            address.Add(Address.Street);
            address.Add(Address.DoorNumber.ToString());
            address.Add($"{Address.County}/{Address.City}");
            return address;
        }
        public string FullAddress()
        {
            return $"{GetTitle()}\n ";
        }
    }
}

using Advance_Inheritance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Inheritance.Classes
{
    public class Base : IHuman, IAddress
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Highroad { get; set; }
        public string Street { get; set; }
        public int DoorNumber { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public char Sex { get; set; }
        public DateTime BornDate { get; set; }
        public List<string> GetAddress()
        {
            List<string> address = new List<string>();
            address.Add(Highroad);
            address.Add(Street);
            address.Add(DoorNumber.ToString());
            address.Add($"{County}/{City}");
            return address;
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
        public virtual string GetTitle()
        {
            if (Sex == 'E')
            {
                return $"Dear Mr {Name} {Surname}";
            }
            else
            {
                return $"Dear Ms {Name} {Surname}";
            }
        }
    }
}

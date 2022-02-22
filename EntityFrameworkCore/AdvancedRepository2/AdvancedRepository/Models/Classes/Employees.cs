using AdvancedRepository.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Classes
{
    public class Employees : Base, IAdres
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public decimal Salary { get; set; }
        public int ManagerId { get; set; }
        public bool IsManager { get; set; }
        public string Street { get; set; }
        public string Avenue { get; set; }
        public int CountyId { get; set; }
        public int OutDoorNumber { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string GetTitle()
        {
            if (Gender == 'E')
            {
                return $"Sn Bay {FirstName} {LastName}";
            }
            else
            {
                return $"Sn Bayan {FirstName} {LastName}";
            }
        }

        public int GetAge()
        {
            var today = DateTime.Now;
            var age = today.Year - DateOfBirth.Year;
            var birthday = DateOfBirth.AddYears(age);
            if (birthday > today)
            {
                age++;
            }
            return age;
        }
    }
}

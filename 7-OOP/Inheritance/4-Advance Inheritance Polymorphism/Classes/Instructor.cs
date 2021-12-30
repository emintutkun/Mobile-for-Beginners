using Advance_Inheritance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Inheritance.Classes
{
    public class Instructor : Base, IInstructor
    {
        public string AcademicDegree { get; set; }
        public decimal  Salary { get; set; }
        public decimal SalaryCalculate()
        {
            return Salary * .75m;
        }
        public override string GetTitle()
        {
            return $"Dear {AcademicDegree} {Surname}";
        }
    }
}

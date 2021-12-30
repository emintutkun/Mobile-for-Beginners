using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advance_Inheritance.Interfaces;

namespace Advance_Inheritance.Classes
{
    public class Student : Base, IStudent
    {
        public string Department { get; set; }
        public int Note { get; set; }
        public string NoteCalculate()
        {
            if (Note >= 45)
            {
                return "Well Done";
            }
            else
                return "Sorry";
        }
    }
}

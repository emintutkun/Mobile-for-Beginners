using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.DTOs
{
    public class EmployeesList
    {
        public int EmployeesId { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }
        public string ManagerName { get; set; }
        public int ManagerId { get; set; }
    }
}

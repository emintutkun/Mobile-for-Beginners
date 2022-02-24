using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface IEmployeesRepos : IBaseRepository<Employees>
    {
        List<EmployeesList> GetEmployees();
        List<Employees> GetManagers(int id);
        string GetTitle(int id);
        int Age(int id);
        string FullName(int id);
    }
}

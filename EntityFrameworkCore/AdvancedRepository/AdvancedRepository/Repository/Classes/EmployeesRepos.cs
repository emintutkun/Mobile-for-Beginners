using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Classes
{
    public class EmployeesRepos : BaseRepository<Employees>, IEmployeesRepos
    {
        public EmployeesRepos(SirketContext db) : base(db)
        {

        }

        public int Age(int id)
        {
            var employee = Set().Find(id);
            var today = DateTime.Now;
            var age = today.Year - employee.DateOfBirth.Year;
            var birthday = employee.DateOfBirth.AddYears(age);
            if (birthday > today)
            {
                age++;
            }
            return age;
        }

        public string FullName(int id)
        {
            var fullName = Find(id);
            return fullName.FirstName + " " + fullName.LastName;
        }

        public List<EmployeesList> GetEmployees()
        {
            var employees = Set().Select(x => new EmployeesList
            {
                EmployeesId = x.Id,
                FullName = x.FirstName + " " + x.LastName,
                Salary = x.Salary,
                ManagerName = x.Manager.FirstName + " " + x.Manager.LastName,
                ManagerId = x.ManagerId
            }).ToList();
            return employees;
        }

        public List<Employees> GetManagers(int id)
        {
            var manager = Set().Select(x => new Employees
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Salary = x.Salary
            }).Where(x => x.Id == id).ToList();
            return manager;
        }

        public string GetTitle(int id)
        {
            var employee = Find(id);
            if (employee.Gender == 'E')
            {
                return "Sn Bay" + employee.FirstName + " " + employee.LastName;
            }
            else
            {
                return "Sn Bayan" + employee.FirstName + " " + employee.LastName;
            }
        }
    }
}

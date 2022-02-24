using AdvancedRepository.UoW;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class EmployeesController : Controller
    {
        IUoW _uow;
        public EmployeesController(IUoW uow)
        {
            _uow = uow;
        }
        public IActionResult List()
        {
            return View(_uow._empRepos.GetEmployees());
        }

        public IActionResult RelatedList(int id)
        {
            var manager = _uow._empRepos.GetManagers(id);
            return View(manager);
        }
    }
}

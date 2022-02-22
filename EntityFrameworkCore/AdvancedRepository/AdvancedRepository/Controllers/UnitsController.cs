using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Views;
using AdvancedRepository.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class UnitsController : Controller
    {
        IUnitsRepos _repo;
        UnitsModel _model;
        public UnitsController(IUnitsRepos repo, UnitsModel model)
        {
            _repo = repo;
            _model = model;
        }
        public IActionResult List()
        {
            var units = _repo.GetUnits();
            return View(units);
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Units = new Units();
            _model.Header = "Create Page";
            _model.BtnClass = "btn btn-primary";
            _model.BtnValue = "Create";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(UnitsModel model)
        {
            _repo.Create(model.Units);
            _repo.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Units = _repo.Find(id);
            _model.Header = "Update Page";
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(UnitsModel model)
        {
            _repo.Update(model.Units);
            _repo.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Units = _repo.Find(id);
            _model.Header = "Delete Page";
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Delete";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(UnitsModel model)
        {
            _repo.Delete(model.Units);
            _repo.Save();
            return RedirectToAction("List");
        }
    }
}

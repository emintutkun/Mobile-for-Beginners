using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Views;
using AdvancedRepository.Repository.Interfaces;
using AdvancedRepository.UnitOfWork;
using AdvancedRepository.UoW;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class UnitsController : Controller
    {
        UnitsModel _model;
        IUoW _uow;
        public UnitsController(UnitsModel model, IUoW uow)
        {
            _model = model;
            _uow = uow;
        }
        public IActionResult List()
        {
            var units = _uow._uniRepos.GetUnits();
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
            _uow._uniRepos.Create(model.Units);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Units = _uow._uniRepos.Find(id);
            _model.Header = "Update Page";
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(UnitsModel model)
        {
            _uow._uniRepos.Update(model.Units);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Units = _uow._uniRepos.Find(id);
            _model.Header = "Delete Page";
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Delete";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(UnitsModel model)
        {
            _uow._uniRepos.Delete(model.Units);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }
    }
}

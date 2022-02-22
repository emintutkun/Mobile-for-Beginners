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
    public class SuppliersController : Controller
    {
        ISuppliersRepos _repos;
        SuppliersModel _model;
        public SuppliersController(ISuppliersRepos repos, SuppliersModel model)
        {
            _repos = repos;
            _model = model;
        }
        public IActionResult List()
        {
            var supplier = _repos.GetSuppliers();
            return View(supplier);
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Suppliers = new Suppliers();
            _model.Header = "Create Page";
            _model.BtnClass = "btn btn-primary";
            _model.BtnValue = "Create";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(SuppliersModel model)
        {
            _repos.Create(model.Suppliers);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Suppliers = _repos.Find(id);
            _model.Header = "Update Page";
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(SuppliersModel model)
        {
            _repos.Update(model.Suppliers);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Suppliers = _repos.Find(id);
            _model.Header = "Delete Page";
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Delete";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(SuppliersModel model)
        {
            _repos.Delete(model.Suppliers);
            return RedirectToAction("List");
        }
    }
}

using BasicRepositorySoftDelete.Models.Classes;
using BasicRepositorySoftDelete.Models.Views;
using BasicRepositorySoftDelete.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Controllers
{
    public class CityController : Controller
    {
        CityRepository _rep;
        CityModel _model;
        public CityController(CityRepository rep, CityModel model)
        {
            _rep = rep;
            _model = model;
        }
        public IActionResult List()
        {
            var cities = _rep.List();
            return View(cities);
        }

        public IActionResult Recover()
        {
            var cities = _rep.RecoverList();
            return View("Recover", cities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Header = "Create Page";
            _model.BtnValue = "Create";
            _model.BtnClass = "btn btn-primary";
            _model.City = new City();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(CityModel model)
        {
            _rep.Create(model.City);
            _rep.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update Page";
            _model.BtnValue = "Update";
            _model.BtnClass = "btn btn-success";
            _model.City = _rep.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(CityModel model)
        {
            _rep.Update(model.City);
            _rep.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Header = "Delete Page";
            _model.BtnValue = "Delete";
            _model.BtnClass = "btn btn-danger";
            _model.City = _rep.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(CityModel model)
        {
            _rep.Delete(model.City);
            _rep.Save();
            return RedirectToAction("List");
        }
    }
}

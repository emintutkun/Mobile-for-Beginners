using BasicRepository.Models.Classes;
using BasicRepository.Models.Data;
using BasicRepository.Models.Views;
using BasicRepository.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Controllers
{
    public class CityController : Controller
    {
        IBaseRepository<City> _baseR;
        CityModel _model;
        public CityController(IBaseRepository<City> baseR, CityModel model)
        {
            _baseR = baseR;
            _model = model;
        }
        public IActionResult List()
        {
            var cities = _baseR.List();
            return View(cities);
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
            _baseR.Create(model.City);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update Page";
            _model.BtnValue = "Update";
            _model.BtnClass = "btn btn-success";
            _model.City = _baseR.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(CityModel model)
        {
            _baseR.Update(model.City);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Header = "Delete Page";
            _model.BtnValue = "Delete";
            _model.BtnClass = "btn btn-danger";
            _model.City = _baseR.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(CityModel model)
        {
            _baseR.Delete(model.City);
            return RedirectToAction("List");
        }
        
        //Second way to delete
        /*public IActionResult Delete(int id)
        {
            _baseR.Delete(_baseR.Find(id));
            return RedirectToAction("List");
        }*/


    }
}

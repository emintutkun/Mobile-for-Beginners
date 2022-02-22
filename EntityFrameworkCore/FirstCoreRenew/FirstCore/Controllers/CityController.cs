using FirstCore.Models.ViewModel;
using FirstCore.Models.Data;
using FirstCore.Models.Data.Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Controllers
{
    public class CityController : Controller
    {
        PerContext _db;
        CityModel _model;
        public CityController(PerContext db, CityModel model)
        {
            _db = db;
            _model = model;
        }
        public IActionResult List()
        {
            return View(_db.Set<City>().ToList());
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
            _db.Set<City>().Add(model.City);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update Page";
            _model.BtnValue = "Update";
            _model.BtnClass = "btn btn-success";
            _model.City = _db.Set<City>().Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(CityModel model)
        {
            _db.Set<City>().Update(model.City);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Header = "Delete Page";
            _model.BtnValue = "Delete";
            _model.BtnClass = "btn btn-danger";
            _model.City = _db.Set<City>().Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(CityModel model)
        {
            _db.Set<City>().Remove(model.City);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}

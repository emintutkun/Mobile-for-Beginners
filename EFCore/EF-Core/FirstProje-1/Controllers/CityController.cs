using FirstProje_1.Classes;
using FirstProje_1.Data;
using FirstProje_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProje_1.Controllers
{
    public class CityController : Controller
    {
        PerContext _db;//tanımlıyoruz geleneksel olarak global tanımlama
        CityModel _model;//tanımlıyoruz geleneksel olarak global tanımlama
        public CityController(PerContext db,CityModel model)//Ctor oluşturduk ve parametre olarak percontext db tanımladık.startupta tanımladık artık örneklemeye gerek kalmadı city modeli
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
            _model.Title = "City List";
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create";
            _model.City = new City();
            return View("Crud2", _model);
        }
        [HttpPost]
        public IActionResult Create(CityModel model)
        {
            _db.Set<City>().Add(model.City);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {

            _model.Title = "City List";
            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Delete";
            _model.City = _db.Set<City>().Find(id);
            return View("Crud2", _model);
        }
        [HttpPost]
        public IActionResult Delete(CityModel model)
        {
            _db.Set<City>().Remove(model.City);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            _model.Title = "City List";
            _model.BtnClass = "btn btn-success";
            _model.BtnVal = "Update";
            _model.City = _db.Set<City>().Find(id);
            return View("Crud2", _model);
        }
        [HttpPost]
        public IActionResult Edit(CityModel model)
        {
            _db.Set<City>().Update(model.City);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}

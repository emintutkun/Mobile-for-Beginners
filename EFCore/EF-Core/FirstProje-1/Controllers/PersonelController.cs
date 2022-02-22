using FirstProje_1.Classes;
using FirstProje_1.Data;
using FirstProje_1.DTO;
using FirstProje_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProje_1.Controllers
{
    public class PersonelController : Controller
    {
        PerContext _db;//tanımlıyoruz geleneksel olarak global tanımlama
        PersonelModel _model;
        public PersonelController(PerContext db,PersonelModel model)
        {
            _db = db;
            _model = model;
        }
        public IActionResult List()
        {

            var plist= _db.Set<Personnel>().Select(x => new PersonelDTO
            {
                PersonelId = x.PersonelId,
                Name = x.Name,
                Surname = x.Surname,   
                CityName = x.City.CityName
            }).ToList();
            return View(plist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            _model.Title = "Personnel List";
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create";
            _model.cityList = cityList();
            _model.Personel = new Personnel();
            return View("Crud2", _model);
        }
        [HttpPost]
        public IActionResult Create(PersonelModel model)
        {
            _db.Set<Personnel>().Add(model.Personel);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        private List<City> cityList()
        {
            return _db.Set<City>().Select(x => new City
            {
                CityId =x.CityId,
                CityName = x.CityName
            }).ToList();
            
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Title = "Personnel List";
            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Delete";
            _model.cityList = cityList();
            _model.Personel = _db.Set<Personnel>().Find(id);
            return View("Crud2", _model);
        }
        [HttpPost]
        public IActionResult Delete(PersonelModel model)
        {
            _db.Set<Personnel>().Remove(model.Personel);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            _model.Title = "Personnel List";
            _model.BtnClass = "btn btn-success";
            _model.BtnVal = "Update";
            _model.cityList = cityList();
            _model.Personel = _db.Set<Personnel>().Find(id);
            return View("Crud2", _model);
        }
        [HttpPost]
        public IActionResult Edit(PersonelModel model)
        {
            _db.Set<Personnel>().Update(model.Personel);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

    }
}

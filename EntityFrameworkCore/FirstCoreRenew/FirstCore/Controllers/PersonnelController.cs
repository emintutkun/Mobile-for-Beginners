using FirstCore.Models.Data;
using FirstCore.Models.Data.Classes;
using FirstCore.Models.DTOs;
using FirstCore.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Controllers
{
    public class PersonnelController : Controller
    {
        PerContext _db;
        PersonelModel _model;
        public PersonnelController(PerContext db, PersonelModel model)
        {
            _db = db;
            _model = model;
        }
        public IActionResult List()
        {
            var personels = _db.Set<Personnel>().Select(x => new PersonelDTO
            {
                PersonelId = x.PersonelId,
                Name = x.Name,
                Surname = x.Surname,
                CityName = x.City.CityName
            }).ToList();
            return View(personels);
        }

        private List<City> cityList()
        {
            var cities = _db.Set<City>().Select(x => new City
            {
                CityId = x.CityId,
                CityName = x.CityName
            }).ToList();
            return cities;
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Header = "Create Page";
            _model.BtnClass = "btn btn-primary";
            _model.BtnValue = "Create";
            _model.Personnel = new Personnel();
            _model.cityList = cityList();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(PersonelModel model)
        {
            _db.Set<Personnel>().Add(model.Personnel);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update Page";
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            _model.Personnel = _db.Set<Personnel>().Find(id);
            _model.cityList = cityList();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(PersonelModel model)
        {
            _db.Set<Personnel>().Update(model.Personnel);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Header = "Delete Page";
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Delete";
            _model.Personnel = _db.Set<Personnel>().Find(id);
            _model.cityList = cityList();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(PersonelModel model)
        {
            _db.Set<Personnel>().Remove(model.Personnel);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}

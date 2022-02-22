using BasicRepository.Models.Classes;
using BasicRepository.Models.Data;
using BasicRepository.Models.DTOs;
using BasicRepository.Models.Views;
using BasicRepository.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Controllers
{
    public class PersonelController : Controller
    {
        IBaseRepository<Personel> _baseR;
        PersonelModel _model;
        PerContext _db;
        public PersonelController(IBaseRepository<Personel> baseR, PersonelModel model, PerContext db)
        {
            _baseR = baseR;
            _model = model;
            _db = db;
        }
        public IActionResult List()
        {
            var personels = _baseR.Set().Select(x => new PersonelDTO
            {
                PersonelId = x.PersonelId,
                PersonelName = x.PersonelName,
                PersonelSurname = x.PersonelSurname,
                CityName = x.City.CityName
            }).ToList();
            return View(personels);
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Header = "Create Page";
            _model.BtnClass = "btn btn-primary";
            _model.BtnValue = "Create";
            _model.Personel = new Personel();
            _model.cityList = cityList();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(PersonelModel model)
        {
            _baseR.Create(model.Personel);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update Page";
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            _model.cityList = cityList();
            _model.Personel = _baseR.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(PersonelModel model)
        {
            _baseR.Update(model.Personel);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Header = "Delete Page";
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Delete";
            _model.Personel = _baseR.Find(id);
            _model.cityList = cityList();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(PersonelModel model)
        {
            _baseR.Delete(model.Personel);
            return RedirectToAction("List");
        }

        private List<City> cityList()
        {
            return _db.Set<City>().ToList();
        }
    }
}

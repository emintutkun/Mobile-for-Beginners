using BasicRepositorySoftDelete.Models.Classes;
using BasicRepositorySoftDelete.Models.DTOs;
using BasicRepositorySoftDelete.Models.Views;
using BasicRepositorySoftDelete.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Controllers
{
    public class PersonelController : Controller
    {
        PersonelRepository _rep;
        PersonelModel _model;
        CityRepository _repCity;
        public PersonelController(PersonelRepository rep, PersonelModel model, CityRepository repCity)
        {
            _rep = rep;
            _model = model;
            _repCity = repCity;
        }
        public IActionResult List()
        {
            var personels = _rep.Set().Select(x => new PersonelDTO { 
                Id = x.Id,
                PersonelName = x.PersonelName,
                PersonelSurname = x.PersonelSurname,
                CityName = x.City.CityName,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == false).ToList();
            return View(personels);
        }

        public IActionResult Recover()
        {
            var personels = _rep.Set().Select(x => new PersonelDTO
            {
                Id = x.Id,
                PersonelName = x.PersonelName,
                PersonelSurname = x.PersonelSurname,
                CityName = x.City.CityName,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == true).ToList();
            return View("Recover", personels);
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Header = "Create Page";
            _model.BtnValue = "Create";
            _model.BtnClass = "btn btn-primary";
            _model.cityList = cityList();
            _model.Personel = new Personel();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(PersonelModel model)
        {
            _rep.Create(model.Personel);
            _rep.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update Page";
            _model.BtnValue = "Update";
            _model.BtnClass = "btn btn-success";
            _model.cityList = cityList();
            _model.Personel = _rep.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(PersonelModel model)
        {
            _rep.Update(model.Personel);
            _rep.Save();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Header = "Delete Page";
            _model.BtnValue = "Delete";
            _model.BtnClass = "btn btn-danger";
            _model.cityList = cityList();
            _model.Personel = _rep.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(PersonelModel model)
        {
            _rep.Delete(model.Personel);
            _rep.Save();
            return RedirectToAction("List");
        }

        private List<City> cityList()
        {
            var cList = _repCity.List();
            return cList;
        }
    }
}

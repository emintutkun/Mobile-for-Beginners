using OgrenciProjeCodeFirst.Models.Data;
using OgrenciProjeCodeFirst.Models.DTOs;
using OgrenciProjeCodeFirst.Models.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciProjeCodeFirst.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        PerOgrenciContext db = new PerOgrenciContext();
        public ActionResult List()
        {
            var cities = db.Set<City>().Select(x => new CityDTO
            {
                CityId = x.CityId,
                CityName = x.CityName
            }).ToList();
            return View(cities);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CityModel model = new CityModel();
            model.Header = "Yeni Kayıt Sayfası";
            model.BtnValue = "Yeni Kayıt";
            model.BtnClass = "btn btn-primary";
            model.City = new City();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Create(City model)
        {
            db.Entry(model).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            CityModel model = new CityModel();
            model.Header = "Güncelleme Sayfası";
            model.BtnValue = "Güncelle";
            model.BtnClass = "btn btn-success";
            model.City = db.Set<City>().Find(id);
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Update(City model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            CityModel model = new CityModel();
            model.Header = "Silme Sayfası";
            model.BtnValue = "Sil";
            model.BtnClass = "btn btn-danger";
            model.City = db.Set<City>().Find(id);
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Delete(City model)
        {
            db.Entry(model).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
using PersonelDBFirst.Connection;
using PersonelDBFirst.Models.Data;
using PersonelDBFirst.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelDBFirst.Controllers
{
    public class UlkeController : Controller
    {
        // GET: Ulke
        perdb2Entities db = DbSingleTone.GetConnection();
        public ActionResult List()
        {
            var ulke = db.Set<Ulke>().ToList();
            return View(ulke);
        }
        [HttpGet]
        public ActionResult Create()
        {
            UlkeModel model = new UlkeModel();
            model.Header = "Yeni Kayıt";
            model.BtnClass = "btn btn-primary";
            model.BtnValue = "Yeni Kayıt";
            model.Ulke = new Ulke();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Create(Ulke ulke)
        {
            db.Entry(ulke).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(string id)
        {
            UlkeModel model = new UlkeModel();
            model.Header = "Güncelleme Sayfası";
            model.BtnClass = "btn btn-success";
            model.BtnValue = "Güncelle";
            model.Ulke = db.Set<Ulke>().Find(id);
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Update(Ulke ulke)
        {
            db.Entry(ulke).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            UlkeModel model = new UlkeModel();
            model.Header = "Silme İşlemi";
            model.BtnClass = "btn btn-danger";
            model.BtnValue = "Sil";
            model.Ulke = db.Set<Ulke>().Find(id);
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Delete(Ulke ulke)
        {
            db.Entry(ulke).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
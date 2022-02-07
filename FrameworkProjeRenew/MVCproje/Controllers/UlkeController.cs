using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Framework;
using MVCproje.Classes;
using MVCproje.Models.Views;

namespace MVCproje.Controllers
{
    public class UlkeController : Controller
    {
        // GET: Ulke
        BaseRepo<Ulke> baseUlke = new BaseRepo<Ulke>();
        public ActionResult List()
        {
            var ulkeler = baseUlke.List();
            return View(ulkeler);
        }

        [HttpGet]
        public ActionResult Create()
        {
            UlkeModel model = new UlkeModel();
            model.Baslik = "Yeni Kayıt";
            model.BtnValue = "Yeni Kayıt";
            model.BtnClass = "btn btn-primary";
            model.ulke = new Ulke();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Create(Ulke model)
        {
            baseUlke.Create(model, false);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(dynamic id)
        {
            UlkeModel model = new UlkeModel();
            model.Baslik = "Güncelleme Sayfası";
            model.BtnValue = "Güncelle";
            model.BtnClass = "btn btn-success";
            model.ulke = baseUlke.Find(id);
            return View("Crud", model);
        }
        [HttpPost]
        public ActionResult Update(Ulke model)
        {
            baseUlke.Update(model, model.UlkeId, false);
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Delete(dynamic id)
        {
            UlkeModel model = new UlkeModel();
            model.Baslik = "Silme Sayfası";
            model.BtnValue = "Sil";
            model.BtnClass = "btn btn-danger";
            model.ulke = baseUlke.Find(id);
            return View("Crud", model);
        }
        [HttpPost]
        public ActionResult Delete(Ulke model)
        {
            baseUlke.Delete(model.UlkeId);
            return RedirectToAction("List");
        }


    }
}
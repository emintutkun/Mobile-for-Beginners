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
    public class UnvanController : Controller
    {
        // GET: Unvan
        BaseRepo<Unvan> baseR = new BaseRepo<Unvan>();
        public ActionResult List()
        {   //1.Yol
            //var unvanList = baseR.List("Unvan");
            //2.Yol
            var unvanList = baseR.List();
            return View(unvanList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            UnvanModel model = new UnvanModel();
            model.Baslik = "Yeni Giriş";
            model.BtnClass = "btn btn-primary";
            model.BtnVal = "Yeni Kayıt";
            model.Unvan = new Unvan();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Create(Unvan model)
        {
            baseR.Create(model, true);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(dynamic id)
        {
            UnvanModel model = new UnvanModel();
            model.Baslik = "Güncelleme İşlemi";
            model.BtnVal = "Güncelle";
            model.BtnClass = "btn btn-success";
            model.Unvan = baseR.Find(id);
            return View("Crud", model);
        }
        [HttpPost]
        public ActionResult Update(Unvan model)
        {
            baseR.Update(model, model.UnvanId, true);
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Delete(dynamic id)
        {
            UnvanModel model = new UnvanModel();
            model.Baslik = "Silme İşlemi";
            model.BtnVal = "Sil";
            model.BtnClass = "btn btn-danger";
            model.Unvan = baseR.Find(id);
            return View("Crud", model);
        }
        [HttpPost]
        public ActionResult Delete(Unvan model)
        {
            baseR.Delete(model.UnvanId);
            return RedirectToAction("List");
        }

    }
}
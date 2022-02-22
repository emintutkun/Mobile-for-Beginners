using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelDBFirst.Connection;
using PersonelDBFirst.Models.Data;
using PersonelDBFirst.Models.Views;

namespace PersonelDBFirst.Controllers
{
    public class UnvanController : Controller
    {
        // GET: Unvan
        perdb2Entities db = DbSingleTone.GetConnection();
        public ActionResult List()
        {
            //1.yol
            //var plist = db.Unvan.ToList();
            //2.Yol
            var unvanlist = db.Set<Unvan>().ToList();
            //var uvlist = db.Set<Unvan>().FirstOrDefault().Personels; //Unvan listesinden ilk ünvan ile uyuşan personelleri getirir.
            //var uvlist2 = db.Set<Unvan>().Where(x => x.UnvanId == 2).FirstOrDefault().Personels; //UnvanId = 2 olan personeli getirir.
            return View(unvanlist);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Session["E"] = null;
            UnvanModel model = new UnvanModel();
            model.Baslik = "Yeni Kayıt";
            model.BtnClass = "btn btn-primary";
            model.BtnValue = "Yeni Kayıt";
            model.Type = "hidden";
            model.Unvan = new Unvan();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Create(Unvan model)
        {
            Session["E"] = null;
            //1.Yol
            //db.Unvans.Add(model);
            //2.Yol
            //db.Set<Unvan>().Add(model);
            //3.Yol
            db.Entry(model).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            Session["E"] = "Kayıt işlemi başarılı";
            Session["cls"] = "primary";
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Session["E"] = null;
            UnvanModel model = new UnvanModel();
            model.Baslik = "Silme İşlemi";
            model.BtnClass = "btn btn-danger";
            model.BtnValue = "Sil";
            model.Type = "hidden";
            model.Unvan = db.Set<Unvan>().Find(id);
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Delete(Unvan model)
        {
            try
            {
                Session["E"] = null;
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                
            }
            catch (Exception)
            {
                Session["E"] = $"{model.UnvanId} kaydının bağlantısı var. Silinemez";
                Session["cls"] = "danger";
                
            }
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Session["E"] = null;
            UnvanModel model = new UnvanModel();
            model.Baslik = "Güncelleme İşlemi";
            model.BtnClass = "btn btn-success";
            model.BtnValue = "Güncelle";
            model.Type = "hidden";
            model.Unvan = db.Set<Unvan>().Find(id);
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Update(Unvan model)
        {
            Session["E"] = null;
            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            Session["E"] = "Güncelleme işlemi başarılı";
            Session["cls"] = "success";
            return RedirectToAction("List");
        }
    }
}
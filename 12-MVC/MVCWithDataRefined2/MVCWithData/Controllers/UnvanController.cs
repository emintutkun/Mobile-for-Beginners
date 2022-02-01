using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using MVCWithData.Connection;
using MVCWithData.Models.Classes;
using MVCWithData.Models.Views;

namespace MVCWithData.Controllers
{
    public class UnvanController : Controller
    {
        SqlConnection con = DbConnect.GetConnection();
        // GET: Unvan
        public ActionResult UnvanList()
        {
            string qry = "Select * from Unvan";
            var unvan = con.Query<Unvan>(qry).ToList();
            return View(unvan);
        }

        [HttpGet]

        public ActionResult UnvanUpdate(string id)
        {
            UnvanModel model = new UnvanModel();
            string qry = $"Select * from Unvan where UnvanId = '{id}'";
            model.unvan = con.Query<Unvan>(qry).First();
            model.BtnVal = "Güncelle";
            model.BtnClass = "btn btn-success";
            model.Baslik = "Güncelleme İşlemi";
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult UnvanUpdate(Unvan model)
        {
            string qry = $"Update Unvan set UnvanAd = @UnvanAd where UnvanId = @UnvanId";
            var unvan = con.ExecuteScalar<int>(qry, model);
            return RedirectToAction("UnvanList");
        }

        [HttpGet]
        public ActionResult UnvanDelete(string id)
        {
            string qry = $"select * from Unvan where UnvanId = '{id}'";
            var unvan = con.Query<Unvan>(qry).First();
            return View(unvan);
        }

        [HttpPost]
        public ActionResult UnvanDelete(Unvan model)
        {
            string qry = $"delete from Unvan where UnvanId = @UnvanId";
            var unvan = con.ExecuteScalar<int>(qry, model);
            return RedirectToAction("UnvanList");
        }

        [HttpGet]
        public ActionResult UnvanCreate()
        {
            UnvanModel model = new UnvanModel();
            model.unvan = new Unvan();
            model.BtnVal = "Ekle";
            model.BtnClass = "btn btn-primary";
            model.Baslik = "Yeni Kayıt Ekleme";
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult UnvanCreate(Unvan model)
        {
            string qry = "insert into Unvan(UnvanAd) values (@UnvanAd)";
            var unvan = con.ExecuteScalar<int>(qry, model);
            return RedirectToAction("UnvanList");
        }
    }
}
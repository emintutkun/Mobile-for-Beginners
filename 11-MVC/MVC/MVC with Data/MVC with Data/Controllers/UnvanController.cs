using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using MVCwithData.Models.Classes;

namespace MVCwithData.Controllers
{
    public class UnvanController : Controller
    {
        // GET: Unvan
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        public List<Unvan> Ünvan { get; private set; }
        public ActionResult List()
        {
            string qry = "select * from Unvan";
            var unvanList = con.Query<Unvan>(qry).ToList();
            return View(unvanList);
        }
        [HttpGet]
        public ActionResult Update(string Id)
        {
            string qry = $"select * from Unvan where UnvanId = '{Id}' ";
            var unvan = con.Query<Unvan>(qry).First();
            return View(unvan);
        }
        [HttpPost]
        public ActionResult Update(Unvan model)
        {
            string qry = $"update unvan set unvanAd = @UnvanAd where UnvanId = @UnvanId ";
            DynamicParameters par = new DynamicParameters();
            var unvan = con.ExecuteScalar<int>(qry, model);
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Delete(string Id)
        {
            string qry = $"select * from unvan where unvanId = '{Id}' ";
            var unvan = con.Query<Unvan>(qry).First();
            return View(unvan);
        }
        [HttpPost]
        public ActionResult Delete(Unvan model)
        {
            string qry = "delete  from Unvan where UnvanId = @UnvanId ";
            con.ExecuteScalar<int>(qry, model);
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Create()
        {
            Unvan a = new Unvan();
            return View(a);
        }
        [HttpPost]
        public ActionResult Create(Unvan model)
        {
            string qry = "insert into unvan (unvanAd) values(@unvanAd)";
            con.ExecuteScalar<int>(qry, model);
            return RedirectToAction("List");
        }
    }
}
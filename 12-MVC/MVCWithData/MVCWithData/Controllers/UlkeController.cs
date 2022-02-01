using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using MVCWithData.Models.Classes;

namespace MVCWithData.Controllers
{
    public class UlkeController : Controller
    {
        // GET: Ulke
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        public List<Ulke> Ulke { get; private set; }

        public ActionResult List()
        {
            string qry = "Select * from Ulke";
            var ulkeList = con.Query<Ulke>(qry).ToList();
            return View(ulkeList);
        }
        [HttpGet]
        public ActionResult Update(string Id)
        {
            string qry = $"Select * from Ulke where UlkeId = '{Id}'";
            var ulke = con.Query<Ulke>(qry).First();
            return View(ulke);
        }

        [HttpPost]
        public ActionResult Update(Ulke model)
        {
            string qry = $"update ulke set UlkeAd = @UlkeAd where UlkeId = @UlkeId";
            //1.yol
            //var ulke = con.ExecuteScalar<int>(qry, model);
            //2.Yol
            DynamicParameters par = new DynamicParameters();
            par.Add("@UlkeAd", model.UlkeAd);
            par.Add("@UlkeId", model.UlkeId);
            var ulke = con.ExecuteScalar<int>(qry, par);
            return RedirectToAction("List");
        }
        //1.Yol Delete 
        //[HttpGet]
        //public ActionResult Delete(string Id)
        //{
        //    string qry = $"Delete from Ulke where UlkeId = '{Id}'";
        //    var ulke = con.ExecuteScalar<int>(qry);
        //    return RedirectToAction("List");
        //}

        //2.Yol Delete
        [HttpGet]
        public ActionResult Delete(string Id)
        {
            string qry = $"Select * from Ulke where UlkeId = '{Id}'";
            var ulke = con.Query<Ulke>(qry).First();
            return View(ulke);
        }

        [HttpPost]
        public ActionResult Delete(Ulke model)
        {
            string qry = $"Delete from Ulke where UlkeId = @UlkeId";
            var ulke = con.ExecuteScalar<int>(qry, model);
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Create()
        {
            Ulke u = new Ulke();
            return View(u);
        }

        [HttpPost]
        public ActionResult Create(Ulke model)
        {
            string qry = "Insert into Ulke(UlkeId, UlkeAd) values (@UlkeId, @UlkeAd)";
            var ulke = con.ExecuteScalar<int>(qry, model);
            return RedirectToAction("List");
        }
    }
}
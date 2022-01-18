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
    public class UlkeController : Controller
    {
        // GET: Ulke
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        public List<Ulke> Ülke { get; private set; }
        public ActionResult List()
        {
            string qry = "select * from Ulke";
            var ulkeList = con.Query<Ulke>(qry).ToList();
            return View(ulkeList);
        }
        [HttpGet]
        public ActionResult Update(string Id)
        {
            string qry = $"select * from Ulke where UlkeId = '{Id}' ";
            var ulke = con.Query<Ulke>(qry).First();
            return View(ulke);
        }
        [HttpPost]
        public ActionResult Update(Ulke model)
        {
            string qry = $"update ulke set ulkeAd = @UlkeAd where UlkeId = @UlkeId ";
            DynamicParameters par = new DynamicParameters();
            var ulke = con.ExecuteScalar<int>(qry,model);
            return RedirectToAction("List");
        }
    }
}
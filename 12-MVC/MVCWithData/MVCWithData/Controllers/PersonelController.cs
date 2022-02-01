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
    public class PersonelController : Controller
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        // GET: Personel
        public ActionResult PersonelList()
        {
            string qry = "select * from kisiler";
            var personel = con.Query<Personel>(qry).ToList();
            return View(personel);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using MVCWithData.Models.Classes;
using MVCWithData.Connection;

namespace MVCWithData.Controllers
{
    public class PersonelController : Controller
    {
        SqlConnection con = DbConnect.GetConnection();
        
        // GET: Personel
        public ActionResult PersonelList()
        {
            string qry = "select * from kisiler";
            var personel = con.Query<Personel>(qry).ToList();
            return View(personel);
        }
    }
}
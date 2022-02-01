using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contact2()
        {
            //1.Yol-A --> ViewBag
            Webmaster wm = new Webmaster();
            wm.Ad = "Şamil";
            wm.Mail = "samilyilmaz@gmail.com";
            wm.Tel = 435366;

            ViewBag.Ad = wm.Ad;
            ViewBag.Mail = wm.Mail;
            ViewBag.Tel = wm.Tel;

            //1.Yol-B --> ViewBag
            ViewBag.Webmaster = wm;

            return View();
        }

        public ActionResult Contact3()
        {
            //2.Yol--> Model
            Webmaster wm = new Webmaster();
            wm.Ad = "Şamil";
            wm.Mail = "samilyilmaz@gmail.com";
            wm.Tel = 435366;
            
            return View(wm);
        }
    }
}
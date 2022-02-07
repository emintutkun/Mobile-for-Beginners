using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelDBFirst.Models.Data;
using PersonelDBFirst.Models.DTOs;

namespace PersonelDBFirst.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        perdb2Entities db = new perdb2Entities();
        public ActionResult List()
        {
            //var personeller = db.Set<Personel>().Where(x => x.UnvanId == id).ToList();//Gönderilen id'ye göre personel getirir.
            /*var plist = db.Set<Personel>().Select(x => new
            {
                x.Ad,
                x.Soyad,
                x.Maas,
                x.Unvan.UnvanAd,
                x.Ulke.UlkeAd,
                Yonetici = x.Personel2.Ad + " " + x.Personel2.Soyad
            }).ToList();*/
            var plist = db.Set<Personel>().Select(x => new PersonelDTO
            {
                Ad = x.Ad,
                Ikamet = x.Ulke.UlkeAd,
                Id = x.PersonelId,
                Soyad = x.Soyad,
                UnvanAd = x.Unvan.UnvanAd,
                Yonetici = x.Personel2.Ad + " " + x.Personel2.Soyad
            }).ToList();
            return View(plist);
        }

        public ActionResult SingularList(int UnvanId)
        {
            var personeller = db.Set<Personel>().Select(x => new PersonelDTO
            {
                Ad = x.Ad,
                Ikamet = x.Ulke.UlkeAd,
                Id = x.PersonelId,
                Soyad = x.Soyad,
                UnvanAd = x.Unvan.UnvanAd,
                Yonetici = x.Personel2.Ad + " " + x.Personel2.Soyad,
            })
        .Where(x => x.UnvanId == UnvanId).ToList();//Gönderilen id'ye göre personel getirir.
            return View(personeller);
        }
    }
}
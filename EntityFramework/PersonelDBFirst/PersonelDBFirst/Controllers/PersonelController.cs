using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelDBFirst.Connection;
using PersonelDBFirst.Models.Classes;
using PersonelDBFirst.Models.Data;
using PersonelDBFirst.Models.DTOs;
using PersonelDBFirst.Models.Views;

namespace PersonelDBFirst.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        static perdb2Entities db = DbSingleTone.GetConnection();
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
                Maas = (decimal)x.Maas,
                UnvanAd = x.Unvan.UnvanAd,
                Yonetici = x.Personel2.Ad + " " + x.Personel2.Soyad,
                UlkeAd = x.Ulke1.UlkeAd
            }).ToList();
            return View(plist);
        }

        public ActionResult SingularList(int id)
        {
            var personeller = db.Set<Personel>().Select(x => new PersonelDTO
            {
                Ad = x.Ad,
                Ikamet = x.Ulke.UlkeAd,
                Id = x.PersonelId,
                Soyad = x.Soyad,
                Maas = (decimal)x.Maas,
                UnvanAd = x.Unvan.UnvanAd,
                Yonetici = x.Personel2.Ad + " " + x.Personel2.Soyad,
                UnvanId = (int)x.UnvanId,
                UlkeAd = x.Ulke1.UlkeAd
            })
        .Where(x => x.UnvanId == id).ToList();//Gönderilen id'ye göre personel getirir.
            return View("List", personeller);
        }
        [HttpGet]
        public ActionResult Create()
        {
            PersonelModel model = new PersonelModel();
            model.Header = "Yeni Kayıt Sayfası";
            model.BtnValue = "Yeni Kayıt";
            model.BtnClass = "btn btn-primary";
            model.Personel = new Personel();
            model.yoneticiList = yoneticiList();
            model.ulkeList = ulkeList();
            model.unvanList = unvanList();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Create(Personel personel)
        {
            db.Entry(personel).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            PersonelModel model = new PersonelModel();
            model.Header = "Güncelleme İşlemi";
            model.BtnValue = "Güncelle";
            model.BtnClass = "btn btn-success";
            model.Personel = db.Set<Personel>().Find(id);
            model.yoneticiList = yoneticiList();
            model.ulkeList = ulkeList();
            model.unvanList = unvanList();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Update(Personel personel)
        {
            // db.Entry(personel).State = EntityState.Modified;
            Personel p = db.Set<Personel>().Find(personel.PersonelId);
            p.Ad = personel.Ad;
            p.Soyad = personel.Soyad;
            p.UnvanId = personel.UnvanId;
            p.Maas = personel.Maas;
            p.UlkeId = personel.UlkeId;
            p.UyrukId = personel.UyrukId;
            p.YoneticiId = personel.YoneticiId;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var personel = db.Set<Personel>().Find(id);
            return View(personel);
        }

        [HttpPost]
        public ActionResult Delete(Personel personel)
        {
            //db.Entry(personel).State = EntityState.Deleted; //Hata veriyirrrr
            Personel p = db.Set<Personel>().Find(personel.PersonelId);
            db.Personels.Remove(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }


        /*private List<Yonetici> yoneticiList()
        {
            var yoneticiler = db.Set<Personel>().Select(x => new Yonetici
            {
                YoneticiId = x.YoneticiId ?? 0,
                YoneticiAd = x.Personel2.Ad + " " + x.Personel2.Soyad
            }).Distinct().ToList();
            return yoneticiler;
        }*/
        private List<UlkeDTO> ulkeList()
        {
            var ulke = db.Set<Ulke>().Select(x => new UlkeDTO
            {
                UlkeId = x.UlkeId,
                UlkeAd = x.UlkeAd
            }).ToList();
            return ulke;
        }

        private List<UnvanDTO> unvanList()
        {
            var unvan = db.Set<Unvan>().Select(x => new UnvanDTO
            {
                UnvanId = x.UnvanId,
                UnvanAd = x.UnvanAd
            }).ToList();
            return unvan;
        }

        private List<PersonelDTOSelect> yoneticiList()
        {
            var yonetici = db.Set<Personel>().Select(x => new PersonelDTOSelect
            {
                YoneticiId = x.YoneticiId ?? 0,
                AdSoy = x.Personel2.Ad + " " + x.Personel2.Soyad
            }).Distinct().ToList();//Where(x => x.YoneticiId != 0) bu komut ile null olan değerler dahil edilmez
            return yonetici;
        }
    }
}
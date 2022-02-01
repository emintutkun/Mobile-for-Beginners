using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using MVCWithData.DTOs;
using MVCWithData.Connection;
using MVCWithData.Models.Views;
using MVCWithData.Models.Classes;

namespace MVCWithData.Controllers
{
    public class PersonelController : Controller
    {
        SqlConnection con = DbConnect.GetConnection();
        
        // GET: Personel
        public ActionResult PersonelList()
        {
            string qry = "select p.PersonelId PersonelId, p.Ad Ad, p.Soyad Soyad, u.UlkeAd UlkeId, uy.UlkeAd UyrukId, " +
                "ISNULL (m.Ad + ' ' + m.Soyad, 'Başkan') Yonetici, p.Maas Maas, isnull (un.UnvanAd,'-') UnvanId from Personel p " +
                "join Ulke u on p.UlkeId = u.UlkeId " +
                "join Ulke uy on p.UyrukId = uy.UlkeId " +
                "left join Personel m on p.YoneticiId = m.PersonelId " +
                "left join Unvan un on p.UnvanId = un.UnvanId";
            var plist = con.Query<Personel>(qry).ToList();
            return View(plist);
        }
        
        [HttpGet]
        public ActionResult Update(int id)
        {
            PersonelModel model = new PersonelModel();
            model.Baslik = "Güncelleme İşlemi";
            model.BtnVal = "Güncelle";
            model.BtnClass = "btn btn-success";
            model.Personel = GetPersonel(id);
            model.UnvanList = GetUnvanList();
            model.UlkeList = GetUlkeList();
            model.YoneticiList = GetYoneticiList();
            return View("Crud", model);
        }
        [HttpPost]
        public ActionResult Update(PersonelModel model)
        {
            string qry = "update Personel set Ad = @Ad, Soyad = @Soyad, Maas = @Maas, UnvanId = @UnvanId, Uyruk = @Uyruk, Ikamet = @Ikamet, Yonetici = @Yonetici where PersonelId = @PersonelId";
            var personel = con.ExecuteScalar<int>(qry, model.Personel);
            return RedirectToAction("PersonelList");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            PersonelModel model = new PersonelModel();
            model.Baslik = "Silme İşlemi";
            model.BtnVal = "Sil";
            model.BtnClass = "btn btn-danger";
            model.Personel = GetPersonel(id);
            model.UnvanList = GetUnvanList();
            model.UlkeList = GetUlkeList();
            model.YoneticiList = GetYoneticiList();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Delete(PersonelModel model)
        {
            string qry = "delete from Personel where PersonelId = @PersonelId";
            con.ExecuteScalar<int>(qry, model.Personel);
            return RedirectToAction("PersonelList");
        }

        [HttpGet]
        public ActionResult Create()
        {
            PersonelModel model = new PersonelModel();
            model.Baslik = "Yeni Kayıt İşlemi";
            model.BtnVal = "Ekle";
            model.BtnClass = "btn btn-primary";
            model.Personel = new Personel();
            model.UnvanList = GetUnvanList();
            model.UlkeList = GetUlkeList();
            model.YoneticiList = GetYoneticiList();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Create(PersonelModel model)
        {
            string qry = "insert into Personel(Ad,Soyad,Maas,UnvanId,UyrukId,UlkeId,Yonetici) values (@Ad,@Soyad,@Maas,@UnvanId,@UyrukId,@UlkeId,@Yonetici)";
            con.ExecuteScalar<int>(qry, model.Personel);
            return RedirectToAction("PersonelList");
        }
        private List<Unvan> GetUnvanList()
        {
            string qry = "select * from Unvan";
            return con.Query<Unvan>(qry).ToList();   
        }
        private List<Ulke> GetUlkeList()
        {
            string qry = "select * from Ulke";
            return con.Query<Ulke>(qry).ToList();
        }
        private List<Yonetici> GetYoneticiList()
        {
            string qry = "select p.PersonelId YoneticiId, p.Ad YoneticiAd, p.Soyad YoneticiSoyad from Personel p " +
                "left join Personel y on p.YoneticiId = y.PersonelId";
            return con.Query<Yonetici>(qry).ToList();
        }
        private Personel GetPersonel(int id)
        {
            string qry = "select p.PersonelId PersonelId, p.Ad Ad, p.Soyad Soyad, u.UlkeAd Ikamet, uy.UlkeAd Uyruk, " +
                "ISNULL (m.Ad + ' ' + m.Soyad, 'Başkan') Yonetici, p.Maas Maas, isnull (un.UnvanAd,'-') UnvanAd from Personel p " +
                "join Ulke u on p.UlkeId = u.UlkeId " +
                "join Ulke uy on p.UyrukId = uy.UlkeId " +
                "left join Personel m on p.YoneticiId = m.PersonelId " +
                "left join Unvan un on p.UnvanId = un.UnvanId " + $"where p.PersonelId = '{id}'";
            return con.Query<Personel>(qry).First();
        }
    }
}
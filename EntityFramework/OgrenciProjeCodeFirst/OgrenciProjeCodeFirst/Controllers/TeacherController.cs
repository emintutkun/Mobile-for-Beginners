using OgrenciProjeCodeFirst.Models.Data;
using OgrenciProjeCodeFirst.Models.DTOs;
using OgrenciProjeCodeFirst.Models.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciProjeCodeFirst.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        PerOgrenciContext db = new PerOgrenciContext();
        public ActionResult List()
        {
            var teachers = db.Set<Teacher>().Select(x => new TeacherDTO
            {
                Id = x.Id,
                Name = x.Name,
                SurName = x.SurName,
                Salary = x.Salary,
                CityName = x.City.CityName,
                MotherName = x.MotherName,
                FullName = x.Name + " " + x.SurName  
            }).ToList();
            return View(teachers);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            TeacherModel model = new TeacherModel();
            model.Header = "Yeni Kayıt Sayfası";
            model.BtnValue = "Yeni Kayıt";
            model.BtnClass = "btn btn-primary";
            model.Teacher = new Teacher();
            model.cityList = cityList();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Create(Teacher model)
        {
            db.Entry(model).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            TeacherModel model = new TeacherModel();
            model.Header = "Güncelleme Sayfası";
            model.BtnValue = "Güncelle";
            model.BtnClass = "btn btn-success";
            model.Teacher = db.Set<Teacher>().Find(id);
            model.cityList = cityList();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Update(Teacher model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            TeacherModel model = new TeacherModel();
            model.Header = "Silme Sayfası";
            model.BtnValue = "Sil";
            model.BtnClass = "btn btn-danger";
            model.Teacher = db.Set<Teacher>().Find(id);
            model.cityList = cityList();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Delete(Teacher model)
        {
            db.Entry(model).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        private List<CityDTO> cityList()
        {
            var cities = db.Set<City>().Select(x => new CityDTO
            {
                CityId = x.CityId,
                CityName = x.CityName
            }).ToList();
            return cities;
        }
    }
}
using OgrenciProjeCodeFirst.Models.Data;
using OgrenciProjeCodeFirst.Models.DTOs;
using OgrenciProjeCodeFirst.Models.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciProjeCodeFirst.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        PerOgrenciContext db = new PerOgrenciContext();
        public ActionResult List()
        {
            var students = db.Set<Student>().Select(x => new StudentDTO
            {
                Id = x.Id,
                Name = x.Name,
                SurName = x.SurName,
                CityName = x.City.CityName,
                MotherName = x.MotherName,
                FullName = x.Name + " " + x.SurName
            }).ToList();
            return View(students);
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

        [HttpGet]
        public ActionResult Create()
        {
            StudentModel model = new StudentModel();
            model.Header = "Yeni Kayıt Sayfası";
            model.BtnClass = "btn btn-primary";
            model.BtnValue = "Yeni Kayıt";
            model.Student = new Student();
            model.cityList = cityList();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Create(Student model)
        {
            db.Entry(model).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            StudentModel model = new StudentModel();
            model.Header = "Güncelleme Sayfası";
            model.BtnClass = "btn btn-success";
            model.BtnValue = "Güncelle";
            model.Student = db.Set<Student>().Find(id);
            model.cityList = cityList();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Update(Student model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            StudentModel model = new StudentModel();
            model.Header = "Silme Sayfası";
            model.BtnClass = "btn btn-danger";
            model.BtnValue = "Sil";
            model.Student = db.Set<Student>().Find(id);
            model.cityList = cityList();
            return View("Crud", model);
        }

        [HttpPost]
        public ActionResult Delete(Student model)
        {
            db.Entry(model).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
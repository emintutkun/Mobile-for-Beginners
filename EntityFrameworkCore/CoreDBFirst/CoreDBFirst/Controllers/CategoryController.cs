using CoreDBFirst.Models.Data;
using CoreDBFirst.Models.DTOs;
using CoreDBFirst.Models.Views;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDBFirst.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext _db;
        CategoryModel _model;
        public CategoryController(NorthwindContext db, CategoryModel model)
        {
            _db = db;
            _model = model;
        }
        public IActionResult List()
        {
            var categories = _db.Set<Category>().Select(x => new CategoryDTO
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                Description = x.Description
            }).ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Header = "Create Page";
            _model.BtnClass = "btn btn-primary";
            _model.BtnValue = "Create";
            _model.Category = new Category();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            _db.Set<Category>().Add(model.Category);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update Page";
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            _model.Category = _db.Set<Category>().Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(CategoryModel model)
        {
            _db.Set<Category>().Update(model.Category);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Header = "Delete Page";
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Update";
            _model.Category = _db.Set<Category>().Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(CategoryModel model)
        {
            _db.Set<Category>().Remove(model.Category);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

    }
}

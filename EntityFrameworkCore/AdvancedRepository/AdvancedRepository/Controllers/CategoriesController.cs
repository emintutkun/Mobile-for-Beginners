using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Views;
using AdvancedRepository.Repository.Classes;
using AdvancedRepository.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class CategoriesController : Controller
    {
        ICategoriesRepos _repos;
        CategoriesModel _model;
        public CategoriesController(ICategoriesRepos repos, CategoriesModel model)
        {
            _repos = repos;
            _model = model;
        }
        public IActionResult List()
        {
            var categories = _repos.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Categories = new Categories();
            _model.Header = "Create Page";
            _model.BtnClass = "btn btn-primary";
            _model.BtnValue = "Create";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(CategoriesModel model)
        {
            _repos.Create(model.Categories);
            _repos.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Categories = _repos.Find(id);
            _model.Header = "Update Page";
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(CategoriesModel model)
        {
            _repos.Update(model.Categories);
            _repos.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Categories = _repos.Find(id);
            _model.Header = "Delete Page";
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Delete";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(CategoriesModel model)
        {
            _repos.Delete(model.Categories);
            _repos.Save();
            return RedirectToAction("List");
        }
    }
}

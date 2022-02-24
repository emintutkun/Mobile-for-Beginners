using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Views;
using AdvancedRepository.Repository.Classes;
using AdvancedRepository.Repository.Interfaces;
using AdvancedRepository.UnitOfWork;
using AdvancedRepository.UoW;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class CategoriesController : Controller
    {
        IUoW _uow;
        CategoriesModel _model;
        public CategoriesController(IUoW uow, CategoriesModel model)
        {
            _uow = uow;
            _model = model;
        }
        public IActionResult List()
        {
            var categories = _uow._catRepos.GetCategories();
            return View(categories);
        }

        public IActionResult RelatedList(int id)
        {
            var categories = _uow._proRepos.GetRelatedProducts(id);
            return View("RelatedList", categories);
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
            _uow._catRepos.Create(model.Categories);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Categories = _uow._catRepos.Find(id);
            _model.Header = "Update Page";
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(CategoriesModel model)
        {
            _uow._catRepos.Update(model.Categories);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Categories = _uow._catRepos.Find(id);
            _model.Header = "Delete Page";
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Delete";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(CategoriesModel model)
        {
            _uow._catRepos.Delete(model.Categories);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }
    }
}

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
    public class ProductsController : Controller
    {
        ProductsModel _model;
        IUoW _uow;
        public ProductsController(ProductsModel model, IUoW uow)
        {
            _model = model;
            _uow = uow;
        }
        public IActionResult List()
        {
            var list = _uow._proRepos.GetProductsLists();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Products = new Products();
            _model.BtnClass = "btn btn-primary";
            _model.BtnValue = "Create";
            _model.suppliersList = _uow._supRepos.GetSuppliers();
            _model.categoriesList = _uow._catRepos.GetCategories();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(ProductsModel model)
        {
            var list = _uow._proRepos.Create(model.Products);
            _uow.Commit();
            _uow.Dispose();
            return View(list);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Products = _uow._proRepos.Find(id);
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            _model.suppliersList = _uow._supRepos.GetSuppliers();
            _model.categoriesList = _uow._catRepos.GetCategories();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(ProductsModel model)
        {
            var list = _uow._proRepos.Update(model.Products);
            _uow.Commit();
            _uow.Dispose();
            return View(list);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Products = _uow._proRepos.Find(id);
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Delete";
            _model.suppliersList = _uow._supRepos.GetSuppliers();
            _model.categoriesList = _uow._catRepos.GetCategories();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(ProductsModel model)
        {
            var list = _uow._proRepos.Delete(model.Products);
            _uow.Commit();
            _uow.Dispose();
            return View(list);
        }

    }
}

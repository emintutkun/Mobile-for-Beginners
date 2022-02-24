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
    public class ProductsController : Controller
    {
        IProductsRepos _repo;
        ISuppliersRepos _repoSup;
        IUnitsRepos _repoUnit;
        ICategoriesRepos _repoCat;
        ProductsModel _model;
        public ProductsController(IProductsRepos repo, ProductsModel model, ISuppliersRepos repoSup, IUnitsRepos reposUnit, ICategoriesRepos repoCat)
        {
            _repo = repo;
            _model = model;
            _repoSup = repoSup;
            _repoUnit = reposUnit;
            _repoCat = repoCat;
        }
        public IActionResult List()
        {
            var list = _repo.GetProductsLists();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Products = new Products();
            _model.BtnClass = "btn btn-primary";
            _model.BtnValue = "Create";
            _model.unitsList = _repoUnit.GetUnits();
            _model.suppliersList = _repoSup.GetSuppliers();
            _model.categoriesList = _repoCat.GetCategories();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(ProductsModel model)
        {
            var list = _repo.Create(model.Products);
            return View(list);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Products = _repo.Find(id);
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            _model.unitsList = _repoUnit.GetUnits();
            _model.suppliersList = _repoSup.GetSuppliers();
            _model.categoriesList = _repoCat.GetCategories();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(ProductsModel model)
        {
            var list = _repo.Update(model.Products);
            return View(list);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Products = _repo.Find(id);
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Delete";
            _model.unitsList = _repoUnit.GetUnits();
            _model.suppliersList = _repoSup.GetSuppliers();
            _model.categoriesList = _repoCat.GetCategories();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(ProductsModel model)
        {
            var list = _repo.Delete(model.Products);
            return View(list);
        }

    }
}

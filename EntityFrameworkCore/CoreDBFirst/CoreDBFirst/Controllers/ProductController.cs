using CoreDBFirst.Models.Data;
using CoreDBFirst.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDBFirst.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext _db;
        public ProductController(NorthwindContext db)
        {
            _db = db;
        }
        public IActionResult List()
        {
            var plist = _db.Set<Product>().FromSqlRaw("select ProductID, ProductName, CompanyName, CategoryName, UnitPrice from Products p" + " " +
                "inner join Suppliers s on p.SupplierID = s.SupplierID" + " " +
                "inner join Categories c on p.CategoryID = c.CategoryID").ToList();
            return View(plist);
        }
    }
}

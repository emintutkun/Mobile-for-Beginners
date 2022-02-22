using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Classes
{
    public class ProductsRepos : BaseRepository<Products>, IProductsRepos
    {
        public ProductsRepos(SirketContext db) : base (db)
        {
            
        }
        public List<ProductsList> GetProductsLists()
        {
            var productsList = Set().Select(x => new ProductsList { 
                Id = x.Id,
                ProductName = x.ProductName,
                CompanyName = x.Supplier.CompanyName,
                CategoryName = x.Categories.CategoryName
            }).ToList();
            return productsList;        
        }

        
    }
}

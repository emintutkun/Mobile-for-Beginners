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
    public class CategoriesRepos : BaseRepository<Categories>, ICategoriesRepos
    {
        public CategoriesRepos(SirketContext db) : base (db)
        {

        }

        public List<CategoriesList> GetCategories()
        {
            var categories = Set().Select(x => new CategoriesList
            {
                Id = x.Id,
                CategoryName = x.CategoryName
            }).ToList();
            return categories;
        }
    }
}

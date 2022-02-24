using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Classes;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.UnitOfWork
{
    public class UnitOfWork1 : IUnitOfWork
    {
        public ICategoriesRepos _catRepos { get; private set; }

        public IProductsRepos _proRepos { get; private set; }

        public ISuppliersRepos _supRepos { get; private set; }

        public IUnitsRepos _uniRepos { get; private set; }

        private readonly SirketContext _db;

        public UnitOfWork1(SirketContext db)
        {
            
            _catRepos = new CategoriesRepos(db);
            _proRepos = new ProductsRepos(db);
            _supRepos = new SuppliersRepos(db);
            _uniRepos = new UnitsRepos(db);
        }
        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}

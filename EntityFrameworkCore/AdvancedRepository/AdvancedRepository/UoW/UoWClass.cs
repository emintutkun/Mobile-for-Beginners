using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.UoW
{
    public class UoWClass : IUoW
    {
        public ICategoriesRepos _catRepos { get; private set; }

        public IProductsRepos _proRepos { get; private set; }

        public ISuppliersRepos _supRepos { get; private set; }

        public IUnitsRepos _uniRepos { get; private set; }

        public IEmployeesRepos _empRepos { get; private set; }

        SirketContext _db;

        public UoWClass(SirketContext db, ICategoriesRepos catRepos, IProductsRepos proRepos, ISuppliersRepos supRepos, IUnitsRepos uniRepos, IEmployeesRepos empRepos)
        {
            _db = db;
            _catRepos = catRepos;
            _proRepos = proRepos;
            _supRepos = supRepos;
            _uniRepos = uniRepos;
            _empRepos = empRepos;
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

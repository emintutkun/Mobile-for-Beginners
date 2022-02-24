using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICategoriesRepos _catRepos { get; }
        IProductsRepos _proRepos { get; }
        ISuppliersRepos _supRepos { get; }
        IUnitsRepos _uniRepos { get; }
        void Commit(); //save changes görevi yapacak
        void Dispose();
    }
}

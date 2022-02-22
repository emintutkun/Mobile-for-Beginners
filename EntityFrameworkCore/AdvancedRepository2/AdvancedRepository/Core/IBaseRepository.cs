using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Core
{
    public interface IBaseRepository<T> where T : class
    {
        bool Update(T entity);
        bool Create(T entity);
        bool Delete(T entity);
        DbSet<T> Set();
        T Find(int id);
        List<T> List();
        void Save();
    }
}

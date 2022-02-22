using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Repos
{
    public interface IBaseRepository<T> where T : class
    {
        bool Update(T entity);
        bool Create(T entity);
        bool Delete(T entity);
        DbSet<T> Set();
        T Find(int id);
        List<T> List();
        List<T> RecoverList();
        void Save();
        void Recover(int id);
    }
}

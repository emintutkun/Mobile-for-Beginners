using BasicRepository.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BasicRepository.Repos
{
    public class BaseRepo<T> : IBaseRepository<T> where T : class
    {
        PerContext _db;
        public BaseRepo(PerContext db)
        {
            _db = db;
        }
        public bool Create(T entity)
        {
            try
            {
                Set().Add(entity);
               // _db.Entry(entity).State = EntityState.Added; //second way to implement
                Save();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                Set().Remove(entity);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public T Find(int id)
        {
            return Set().Find(id);
        }

        public List<T> List()
        {
            return Set().ToList();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }

        public bool Update(T entity)
        {
            try
            {
                Set().Update(entity);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}

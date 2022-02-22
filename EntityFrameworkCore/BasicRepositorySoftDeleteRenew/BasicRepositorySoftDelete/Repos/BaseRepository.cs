using BasicRepositorySoftDelete.Models.Classes;
using BasicRepositorySoftDelete.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Repos
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        PerContext _db;
        public BaseRepository(PerContext db)
        {
            _db = db;
        }
        public bool Create(T entity)
        {
            try
            {
                entity.Deleted = false;
                Set().Add(entity);
                // _db.Entry(entity).State = EntityState.Added; //second way to implement
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
            //ent deleted kolonu true olarak gelecek
            try
            {
                entity.Deleted = true;
                Set().Update(entity);
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
            return Set().Where(x => x.Deleted == false && x.Id == id).FirstOrDefault();
        }

        public List<T> List()
        {
            return Set().Where(x => x.Deleted == false).ToList();
        }

        public void Recover(int id)
        {
            T ent = Set().Where(x => x.Deleted == true && x.Id == id).FirstOrDefault();
            ent.Deleted = false;
        }

        public List<T> RecoverList()
        {
            return Set().Where(x => x.Deleted == true).ToList();
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

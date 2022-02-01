using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public interface BaseRepository<T> where T: class
    {
        void Delete(int id);
        void Update(T entity, int id);
        void Create(T entity);
        T Find(int id);
        List<T> List();
        List<PropertyInfo> GetProperties();
    }
}

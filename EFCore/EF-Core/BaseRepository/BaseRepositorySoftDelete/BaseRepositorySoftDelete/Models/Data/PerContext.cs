using BaseRepositorySoftDelete.Models.Data.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseRepositorySoftDelete.Models.Data
{
    public class PerContext:DbContext
    {
        public PerContext(DbContextOptions<PerContext> op):base(op)
        {

        }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<City> City { get; set; }

    }
}

using FirstCore.Models.Data.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models.Data
{
    public class PerContext : DbContext
    {
        public PerContext(DbContextOptions<PerContext> options) : base(options)
        {
            
        }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}

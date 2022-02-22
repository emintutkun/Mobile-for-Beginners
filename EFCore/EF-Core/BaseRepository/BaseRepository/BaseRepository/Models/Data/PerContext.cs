using BaseRepository.Models.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseRepository.Models.Data
{
    public class PerContext : DbContext
    {
        public PerContext(DbContextOptions<PerContext> options) : base(options)
        {

        }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<City> City { get; set; }

    }
}

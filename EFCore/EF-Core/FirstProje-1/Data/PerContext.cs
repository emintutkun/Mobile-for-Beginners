using FirstProje_1.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProje_1.Data
{
    public class PerContext: DbContext//dbcontextcore entityframework kütüphanesinden alıyor.
    {
        public PerContext(DbContextOptions<PerContext> options) : base(options)
        {

        }
        public DbSet<Personnel> Personel { get; set; }//db set tanımlamalarını yaptık
        public DbSet<City> City { get; set; }
    }
}

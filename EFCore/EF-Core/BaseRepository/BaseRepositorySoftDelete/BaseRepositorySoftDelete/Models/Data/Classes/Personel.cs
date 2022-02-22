using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaseRepositorySoftDelete.Models.Data.Classes
{
    public class Personel:Base
    {
        public int CityId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }

    }
}

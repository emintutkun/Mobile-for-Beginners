using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Models.Classes
{
    public class City : Base
    {
        public string CityName { get; set; }
        public ICollection<Personel> Personel { get; set; }
    }
}

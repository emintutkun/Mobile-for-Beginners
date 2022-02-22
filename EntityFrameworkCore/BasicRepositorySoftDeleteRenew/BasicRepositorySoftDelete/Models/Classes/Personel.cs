using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Models.Classes
{
    public class Personel : Base
    {
        public int CityId { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}

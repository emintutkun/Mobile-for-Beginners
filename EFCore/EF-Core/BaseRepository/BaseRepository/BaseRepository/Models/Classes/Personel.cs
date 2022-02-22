using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaseRepository.Models.Classes
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public int CityId { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }


    }
}

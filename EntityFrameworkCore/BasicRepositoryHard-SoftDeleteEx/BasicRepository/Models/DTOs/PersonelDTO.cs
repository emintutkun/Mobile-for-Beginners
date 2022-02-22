using BasicRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Models.DTOs
{
    public class PersonelDTO
    { 
        public int PersonelId { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        public string CityName { get; set; }
    }
}

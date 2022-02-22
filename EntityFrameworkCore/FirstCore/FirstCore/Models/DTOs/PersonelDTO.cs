using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models.DTOs
{
    public class PersonelDTO
    {
        public int PersonelId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CityName { get; set; }
    }
}

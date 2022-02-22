using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Models.DTOs
{
    public class PersonelDTO
    {
        public int Id { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        public string CityName { get; set; }
        public bool Deleted { get; set; }
    }
}

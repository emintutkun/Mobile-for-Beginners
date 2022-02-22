using FirstProje_1.Classes;
using FirstProje_1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProje_1.Models
{
    public class PersonelModel
    {
        public Personnel Personel { get; set; }
        public string BtnClass { get; set; }
        public string BtnVal { get; set; }
        public string Title { get; set; }
        public List<City> cityList { get; set; }       
    }
}

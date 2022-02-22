using BasicRepositorySoftDelete.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Models.Views
{
    public class PersonelModel
    {
        public Personel Personel { get; set; }
        public string Header { get; set; }
        public string BtnClass { get; set; }
        public string BtnValue { get; set; }
        public List<City> cityList { get; set; }
    }
}

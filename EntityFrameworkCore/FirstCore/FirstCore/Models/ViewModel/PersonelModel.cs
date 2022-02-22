using FirstCore.Models.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models.ViewModel
{
    public class PersonelModel
    {
        public Personnel Personnel { get; set; }
        public string Header { get; set; }
        public string BtnValue { get; set; }
        public string BtnClass { get; set; }
        public List<City> cityList { get; set; }
    }
}

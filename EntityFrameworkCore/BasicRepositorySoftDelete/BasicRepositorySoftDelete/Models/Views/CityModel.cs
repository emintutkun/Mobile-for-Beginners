using BasicRepositorySoftDelete.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Models.Views
{
    public class CityModel
    {
        public City City { get; set; }
        public string Header { get; set; }
        public string BtnValue { get; set; }
        public string BtnClass { get; set; }
    }
}

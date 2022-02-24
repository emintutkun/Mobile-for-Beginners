using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Views
{
    public class CategoriesModel
    {
        public Categories Categories { get; set; }
        public string Header { get; set; }
        public string BtnValue { get; set; }
        public string BtnClass { get; set; }
    }
}

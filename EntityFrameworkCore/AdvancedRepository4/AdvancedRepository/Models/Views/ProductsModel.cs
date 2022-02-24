using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Views
{
    public class ProductsModel
    {
        public Products Products { get; set; }
        public string Header { get; set; }
        public string BtnValue { get; set; }
        public string BtnClass { get; set; }
        public List<UnitsList> unitsList { get; set; }
        public List<CategoriesList> categoriesList { get; set; }
        public List<SuppliersList> suppliersList { get; set; }
    }
}

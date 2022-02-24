using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Views
{
    public class SuppliersModel
    {
        public Suppliers Suppliers { get; set; }
        public string Header { get; set; }
        public string BtnValue { get; set; }
        public string BtnClass { get; set; }
    }
}

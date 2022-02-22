using CoreDBFirst.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDBFirst.Models.Views
{
    public class CategoryModel
    {
        public Category Category { get; set; }
        public string BtnValue { get; set; }
        public string BtnClass { get; set; }
        public string Header { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Classes
{
    public class Suppliers : Enterprises
    {
        public Suppliers()
        {
            Products = new HashSet<Products>();
        }
        public bool Producer { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}

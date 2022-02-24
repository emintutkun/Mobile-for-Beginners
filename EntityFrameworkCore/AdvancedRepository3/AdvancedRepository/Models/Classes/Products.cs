using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Classes
{
    public class Products : Base
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitId { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public DateTime ProductionDate { get; set; }
        public int Stock { get; set; }

        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }
        [ForeignKey("SupplierId")]
        public Suppliers Supplier { get; set; }
        [ForeignKey("UnitId")]
        public Units Unit { get; set; }
    }
}

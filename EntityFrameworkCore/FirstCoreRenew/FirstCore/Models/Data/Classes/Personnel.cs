using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models.Data.Classes
{
    public class Personnel
    {
        [Key]
        public int PersonelId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}

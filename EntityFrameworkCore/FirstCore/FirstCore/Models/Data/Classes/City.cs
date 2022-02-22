using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models.Data.Classes
{
    public class City
    {
        [Key]
        [Display(Name = "Şehir Id")]
        public int CityId { get; set; }
        [Required, StringLength(10, MinimumLength = 3)]
        [Display(Name = "Şehir Ad")]
        public string CityName { get; set; }
        public string Picture { get; set; }
        public ICollection<Personnel> Personnel { get; set; }
    }
}

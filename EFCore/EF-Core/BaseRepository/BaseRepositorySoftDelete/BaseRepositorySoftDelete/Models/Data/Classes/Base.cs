using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseRepositorySoftDelete.Models.Data.Classes
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
        public bool Deleted { get; set; }



    }
}

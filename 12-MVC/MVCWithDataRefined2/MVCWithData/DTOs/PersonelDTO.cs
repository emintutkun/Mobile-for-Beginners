using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithData.DTOs
{
    public class PersonelDTO  
    {
        public int PersonelId { get; set; }
        public string AdSoyad { get; set; }
        public string Ikamet { get; set; }
        public string Uyruk { get; set; }
        public string Yonetici { get; set; }
    }
}
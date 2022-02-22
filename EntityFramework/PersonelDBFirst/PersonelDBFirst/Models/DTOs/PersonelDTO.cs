using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelDBFirst.Models.DTOs
{
    public class PersonelDTO
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal Maas { get; set; }
        public int UnvanId { get; set; }
        public string UnvanAd { get; set; }
        public string Ikamet { get; set; }
        public string Yonetici { get; set; }
        public string UlkeAd { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithData.Models.Classes
{
    public class Personel
    {
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal Maas { get; set; }
        public string UnvanAd { get; set; }
        public string Patronu { get; set; }
    }
}
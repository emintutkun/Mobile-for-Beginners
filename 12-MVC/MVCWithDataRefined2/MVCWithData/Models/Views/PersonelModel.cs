using MVCWithData.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithData.Models.Views
{
    public class PersonelModel
    {
        public Personel Personel { get; set; }
        public string Baslik { get; set; }
        public string BtnVal { get; set; }
        public string BtnClass { get; set; }
        public List<Unvan> UnvanList { get; set; }
    }
}
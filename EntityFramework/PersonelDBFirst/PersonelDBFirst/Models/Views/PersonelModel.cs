using PersonelDBFirst.Models.Classes;
using PersonelDBFirst.Models.Data;
using PersonelDBFirst.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelDBFirst.Models.Views
{
    public class PersonelModel
    {
        public Personel Personel { get; set; }
        public string BtnValue { get; set; }
        public string BtnClass { get; set; }
        public string Header { get; set; }
        public List<UlkeDTO> ulkeList { get; set; }
        public List<UnvanDTO> unvanList { get; set; }
        public List<PersonelDTOSelect> yoneticiList { get; set; }
    }
}
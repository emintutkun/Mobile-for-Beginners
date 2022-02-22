using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciProjeCodeFirst.Models.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string CityName { get; set; }
        public string MotherName { get; set; }
        public string FullName { get; set; }
    }
}
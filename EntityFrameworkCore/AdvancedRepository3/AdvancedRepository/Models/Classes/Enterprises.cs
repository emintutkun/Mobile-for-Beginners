using AdvancedRepository.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Classes
{
    abstract public class Enterprises : Base, IAdres, IEnterprise
    {
        public string Street { get; set; }
        public string Avenue { get; set; }
        public int CountyId { get; set; }
        public int OutDoorNumber { get; set; }
        public string CompanyName { get; set; }
        public int TaxNumber { get; set; }
        public string ContactName { get; set; }
        public int PhoneNumber { get; set; }

        public string GetTitle()
        {
            return $"Sn {CompanyName} Şirketi";
        }

    }
}

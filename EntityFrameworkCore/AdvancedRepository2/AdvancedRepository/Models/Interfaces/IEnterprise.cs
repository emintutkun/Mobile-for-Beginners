using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Interfaces
{
    public interface IEnterprise
    {
        public string CompanyName { get; set; }
        public int TaxNumber { get; set; }
        public string ContactName { get; set; }
    }
}

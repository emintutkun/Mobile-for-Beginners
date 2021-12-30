using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNo1 { get => CardNo; set => CardNo = value.Substring (0,2)+ "************" + value.Substring(value.Length-4); }

        private string CardNo;


    }
}

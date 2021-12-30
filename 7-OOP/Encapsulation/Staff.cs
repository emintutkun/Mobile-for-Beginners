using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Staff
    {
        public int Id { get; set; }
        public string Name1 { get => name; set => name = value.Substring(0,1).ToUpper() + value.Substring(1); }
        public string Surname1 { get => surname; set => surname = value.ToUpper(); }

        private string name;
        private string surname;
    }
}

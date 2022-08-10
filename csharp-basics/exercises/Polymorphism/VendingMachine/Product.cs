using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public struct Product
    {
        public int Available { get; set; }
        public Money Price { get; set; }
        public string Name { get; set; }
    }
}
